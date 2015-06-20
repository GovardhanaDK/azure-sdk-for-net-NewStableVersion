﻿using System.Collections.Generic;
using System.Net;
using Microsoft.Azure.Management.Network;
using Microsoft.Azure.Management.Network.Models;
using Microsoft.Azure.Management.Resources;
using Microsoft.Azure.Management.Resources.Models;
using Microsoft.Azure.Test;
using Networks.Tests.Helpers;
using ResourceGroups.Tests;
using Xunit;

namespace Networks.Tests
{
    public class NetworkSecurityGroupTests
    {
        [Fact]
        public void NetworkSecurityGroupApiTest()
        {
            var handler = new RecordedDelegatingHandler {StatusCodeToReturn = HttpStatusCode.OK};

            using (var context = UndoContext.Current)
            {
                context.Start();
                var resourcesClient = ResourcesManagementTestUtilities.GetResourceManagementClientWithHandler(handler);
                var networkResourceProviderClient = NetworkManagementTestUtilities.GetNetworkResourceProviderClient(handler);

                // var location = NetworkManagementTestUtilities.GetResourceLocation(resourcesClient, "Microsoft.Network/networkSecurityGroups");
                var location = "west us";

                string resourceGroupName = TestUtilities.GenerateName("csmrg");
                resourcesClient.ResourceGroups.CreateOrUpdate(resourceGroupName,
                    new ResourceGroup
                    {
                        Location = location
                    });

                string networkSecurityGroupName = TestUtilities.GenerateName();

                var networkSecurityGroup = new NetworkSecurityGroup()
                {
                    Location = location,
                };

                // Put Nsg
                var putNsgResponse = networkResourceProviderClient.NetworkSecurityGroups.CreateOrUpdate(resourceGroupName, networkSecurityGroupName, networkSecurityGroup);
                Assert.Equal("Succeeded", putNsgResponse.NetworkSecurityGroup.ProvisioningState);

                // Get NSG
                var getNsgResponse = networkResourceProviderClient.NetworkSecurityGroups.Get(resourceGroupName, networkSecurityGroupName);
                Assert.Equal(networkSecurityGroupName, getNsgResponse.Name);
                Assert.Equal(6, getNsgResponse.DefaultSecurityRules.Count);
                Assert.Equal("AllowVnetInBound", getNsgResponse.DefaultSecurityRules[0].Name);
                Assert.Equal("AllowAzureLoadBalancerInBound", getNsgResponse.DefaultSecurityRules[1].Name);
                Assert.Equal("DenyAllInBound", getNsgResponse.DefaultSecurityRules[2].Name);
                Assert.Equal("AllowVnetOutBound", getNsgResponse.DefaultSecurityRules[3].Name);
                Assert.Equal("AllowInternetOutBound", getNsgResponse.DefaultSecurityRules[4].Name);
                Assert.Equal("DenyAllOutBound", getNsgResponse.DefaultSecurityRules[5].Name);

                // Verify a default security rule
                Assert.Equal(SecurityRuleAccess.Allow, getNsgResponse.DefaultSecurityRules[0].Access);
                Assert.Equal("Allow inbound traffic from all VMs in VNET", getNsgResponse.DefaultSecurityRules[0].Description);
                Assert.Equal("VirtualNetwork", getNsgResponse.DefaultSecurityRules[0].DestinationAddressPrefix);
                Assert.Equal("*", getNsgResponse.DefaultSecurityRules[0].DestinationPortRange);
                Assert.Equal(SecurityRuleDirection.Inbound, getNsgResponse.DefaultSecurityRules[0].Direction);
                Assert.Equal(65000, getNsgResponse.DefaultSecurityRules[0].Priority);
                Assert.Equal(SecurityRuleProtocol.Asterisk, getNsgResponse.DefaultSecurityRules[0].Protocol);
                Assert.Equal("Succeeded", getNsgResponse.DefaultSecurityRules[0].ProvisioningState);
                Assert.Equal("VirtualNetwork", getNsgResponse.DefaultSecurityRules[0].SourceAddressPrefix);
                Assert.Equal("*", getNsgResponse.DefaultSecurityRules[0].SourcePortRange);

                // List NSG
                var listNsgResponse = networkResourceProviderClient.NetworkSecurityGroups.List(resourceGroupName);
                Assert.Equal(1, listNsgResponse.Value.Count);
                Assert.Equal(networkSecurityGroupName, listNsgResponse.Value[0].Name);
                Assert.Equal(6, listNsgResponse.Value[0].DefaultSecurityRules.Count);
                Assert.Equal("AllowVnetInBound", listNsgResponse.Value[0].DefaultSecurityRules[0].Name);
                Assert.Equal("AllowAzureLoadBalancerInBound", listNsgResponse.Value[0].DefaultSecurityRules[1].Name);
                Assert.Equal("DenyAllInBound", listNsgResponse.Value[0].DefaultSecurityRules[2].Name);
                Assert.Equal("AllowVnetOutBound", listNsgResponse.Value[0].DefaultSecurityRules[3].Name);
                Assert.Equal("AllowInternetOutBound", listNsgResponse.Value[0].DefaultSecurityRules[4].Name);
                Assert.Equal("DenyAllOutBound", listNsgResponse.Value[0].DefaultSecurityRules[5].Name);
                Assert.Equal(getNsgResponse.Etag, listNsgResponse.Value[0].Etag);

                // List NSG in a subscription
                var listNsgSubsciptionResponse = networkResourceProviderClient.NetworkSecurityGroups.ListAll();
                Assert.Equal(1, listNsgSubsciptionResponse.Value.Count);
                Assert.Equal(networkSecurityGroupName, listNsgSubsciptionResponse.Value[0].Name);
                Assert.Equal(6, listNsgSubsciptionResponse.Value[0].DefaultSecurityRules.Count);
                Assert.Equal("AllowVnetInBound", listNsgSubsciptionResponse.Value[0].DefaultSecurityRules[0].Name);
                Assert.Equal("AllowAzureLoadBalancerInBound", listNsgSubsciptionResponse.Value[0].DefaultSecurityRules[1].Name);
                Assert.Equal("DenyAllInBound", listNsgSubsciptionResponse.Value[0].DefaultSecurityRules[2].Name);
                Assert.Equal("AllowVnetOutBound", listNsgSubsciptionResponse.Value[0].DefaultSecurityRules[3].Name);
                Assert.Equal("AllowInternetOutBound", listNsgSubsciptionResponse.Value[0].DefaultSecurityRules[4].Name);
                Assert.Equal("DenyAllOutBound", listNsgSubsciptionResponse.Value[0].DefaultSecurityRules[5].Name);
                Assert.Equal(getNsgResponse.Etag, listNsgSubsciptionResponse.Value[0].Etag);

                // Delete NSG
                networkResourceProviderClient.NetworkSecurityGroups.Delete(resourceGroupName, networkSecurityGroupName);

                // List NSG
                listNsgResponse = networkResourceProviderClient.NetworkSecurityGroups.List(resourceGroupName);
                Assert.Equal(0, listNsgResponse.Value.Count);
            }
        }

        [Fact]
        public void NetworkSecurityGroupWithRulesApiTest()
        {
            var handler = new RecordedDelegatingHandler { StatusCodeToReturn = HttpStatusCode.OK };

            using (var context = UndoContext.Current)
            {
                context.Start();
                var resourcesClient = ResourcesManagementTestUtilities.GetResourceManagementClientWithHandler(handler);
                var networkResourceProviderClient = NetworkManagementTestUtilities.GetNetworkResourceProviderClient(handler);

                // var location = NetworkManagementTestUtilities.GetResourceLocation(resourcesClient, "Microsoft.Network/networkSecurityGroups");
                var location = "west us";

                string resourceGroupName = TestUtilities.GenerateName("csmrg");
                resourcesClient.ResourceGroups.CreateOrUpdate(resourceGroupName,
                    new ResourceGroup
                    {
                        Location = location
                    });

                string networkSecurityGroupName = TestUtilities.GenerateName();
                string securityRule1 = TestUtilities.GenerateName();
                string securityRule2 = TestUtilities.GenerateName();

                string destinationPortRange = "123-3500";

                var networkSecurityGroup = new NetworkSecurityGroup()
                {
                    Location = location,
                    SecurityRules = new List<SecurityRule>()
                                    {
                                        new SecurityRule()
                                            {
                                                Name = securityRule1,
                                                Access = SecurityRuleAccess.Allow,
                                                Description = "Test security rule",
                                                DestinationAddressPrefix = "*",
                                                DestinationPortRange = destinationPortRange,
                                                Direction = SecurityRuleDirection.Inbound,
                                                Priority = 500,
                                                Protocol = SecurityRuleProtocol.Tcp,
                                                SourceAddressPrefix = "*",
                                                SourcePortRange = "655"
                                            }
                                    }
                };

                // Put Nsg
                var putNsgResponse = networkResourceProviderClient.NetworkSecurityGroups.CreateOrUpdate(resourceGroupName, networkSecurityGroupName, networkSecurityGroup);
                Assert.Equal("Succeeded", putNsgResponse.NetworkSecurityGroup.ProvisioningState);

                // Get NSG
                var getNsgResponse = networkResourceProviderClient.NetworkSecurityGroups.Get(resourceGroupName, networkSecurityGroupName);
                Assert.Equal(networkSecurityGroupName, getNsgResponse.Name);
                Assert.Equal(6, getNsgResponse.DefaultSecurityRules.Count);
                Assert.Equal("AllowVnetInBound", getNsgResponse.DefaultSecurityRules[0].Name);
                Assert.Equal("AllowAzureLoadBalancerInBound", getNsgResponse.DefaultSecurityRules[1].Name);
                Assert.Equal("DenyAllInBound", getNsgResponse.DefaultSecurityRules[2].Name);
                Assert.Equal("AllowVnetOutBound", getNsgResponse.DefaultSecurityRules[3].Name);
                Assert.Equal("AllowInternetOutBound", getNsgResponse.DefaultSecurityRules[4].Name);
                Assert.Equal("DenyAllOutBound", getNsgResponse.DefaultSecurityRules[5].Name);

                // Verify the security rule
                Assert.Equal(SecurityRuleAccess.Allow, getNsgResponse.SecurityRules[0].Access);
                Assert.Equal("Test security rule", getNsgResponse.SecurityRules[0].Description);
                Assert.Equal("*", getNsgResponse.SecurityRules[0].DestinationAddressPrefix);
                Assert.Equal(destinationPortRange, getNsgResponse.SecurityRules[0].DestinationPortRange);
                Assert.Equal(SecurityRuleDirection.Inbound, getNsgResponse.SecurityRules[0].Direction);
                Assert.Equal(500, getNsgResponse.SecurityRules[0].Priority);
                Assert.Equal(SecurityRuleProtocol.Tcp, getNsgResponse.SecurityRules[0].Protocol);
                Assert.Equal("Succeeded", getNsgResponse.SecurityRules[0].ProvisioningState);
                Assert.Equal("*", getNsgResponse.SecurityRules[0].SourceAddressPrefix);
                Assert.Equal("655", getNsgResponse.SecurityRules[0].SourcePortRange);

                // List NSG
                var listNsgResponse = networkResourceProviderClient.NetworkSecurityGroups.List(resourceGroupName);
                Assert.Equal(1, listNsgResponse.Value.Count);
                Assert.Equal(networkSecurityGroupName, listNsgResponse.Value[0].Name);
                Assert.Equal(6, listNsgResponse.Value[0].DefaultSecurityRules.Count);
                Assert.Equal("AllowVnetInBound", listNsgResponse.Value[0].DefaultSecurityRules[0].Name);
                Assert.Equal("AllowAzureLoadBalancerInBound", listNsgResponse.Value[0].DefaultSecurityRules[1].Name);
                Assert.Equal("DenyAllInBound", listNsgResponse.Value[0].DefaultSecurityRules[2].Name);
                Assert.Equal("AllowVnetOutBound", listNsgResponse.Value[0].DefaultSecurityRules[3].Name);
                Assert.Equal("AllowInternetOutBound", listNsgResponse.Value[0].DefaultSecurityRules[4].Name);
                Assert.Equal("DenyAllOutBound", listNsgResponse.Value[0].DefaultSecurityRules[5].Name);
                Assert.Equal(getNsgResponse.Etag, listNsgResponse.Value[0].Etag);

                // List NSG in a subscription
                var listNsgSubsciptionResponse = networkResourceProviderClient.NetworkSecurityGroups.ListAll();
                Assert.Equal(1, listNsgSubsciptionResponse.Value.Count);
                Assert.Equal(networkSecurityGroupName, listNsgSubsciptionResponse.Value[0].Name);
                Assert.Equal(6, listNsgSubsciptionResponse.Value[0].DefaultSecurityRules.Count);
                Assert.Equal("AllowVnetInBound", listNsgSubsciptionResponse.Value[0].DefaultSecurityRules[0].Name);
                Assert.Equal("AllowAzureLoadBalancerInBound", listNsgSubsciptionResponse.Value[0].DefaultSecurityRules[1].Name);
                Assert.Equal("DenyAllInBound", listNsgSubsciptionResponse.Value[0].DefaultSecurityRules[2].Name);
                Assert.Equal("AllowVnetOutBound", listNsgSubsciptionResponse.Value[0].DefaultSecurityRules[3].Name);
                Assert.Equal("AllowInternetOutBound", listNsgSubsciptionResponse.Value[0].DefaultSecurityRules[4].Name);
                Assert.Equal("DenyAllOutBound", listNsgSubsciptionResponse.Value[0].DefaultSecurityRules[5].Name);
                Assert.Equal(getNsgResponse.Etag, listNsgSubsciptionResponse.Value[0].Etag);

                // Add a new security rule
                var SecurityRule = new SecurityRule()
                                              {
                                                  Name = securityRule2,
                                                  Access = SecurityRuleAccess.Deny,
                                                  Description = "Test outbound security rule",
                                                  DestinationAddressPrefix = "*",
                                                  DestinationPortRange = destinationPortRange,
                                                  Direction = SecurityRuleDirection.Outbound,
                                                  Priority = 501,
                                                  Protocol = SecurityRuleProtocol.Udp,
                                                  SourceAddressPrefix = "*",
                                                  SourcePortRange = "656",
                                              };

                networkSecurityGroup.SecurityRules.Add(SecurityRule);

                putNsgResponse = networkResourceProviderClient.NetworkSecurityGroups.CreateOrUpdate(resourceGroupName, networkSecurityGroupName, networkSecurityGroup);
                Assert.Equal("Succeeded", putNsgResponse.NetworkSecurityGroup.ProvisioningState);

                // Get NSG
                getNsgResponse = networkResourceProviderClient.NetworkSecurityGroups.Get(resourceGroupName, networkSecurityGroupName);

                // Verify the security rule
                Assert.Equal(SecurityRuleAccess.Deny, getNsgResponse.SecurityRules[1].Access);
                Assert.Equal("Test outbound security rule", getNsgResponse.SecurityRules[1].Description);
                Assert.Equal("*", getNsgResponse.SecurityRules[1].DestinationAddressPrefix);
                Assert.Equal(destinationPortRange, getNsgResponse.SecurityRules[1].DestinationPortRange);
                Assert.Equal(SecurityRuleDirection.Outbound, getNsgResponse.SecurityRules[1].Direction);
                Assert.Equal(501, getNsgResponse.SecurityRules[1].Priority);
                Assert.Equal(SecurityRuleProtocol.Udp, getNsgResponse.SecurityRules[1].Protocol);
                Assert.Equal("Succeeded", getNsgResponse.SecurityRules[1].ProvisioningState);
                Assert.Equal("*", getNsgResponse.SecurityRules[1].SourceAddressPrefix);
                Assert.Equal("656", getNsgResponse.SecurityRules[1].SourcePortRange);

                // Delete NSG
                networkResourceProviderClient.NetworkSecurityGroups.Delete(resourceGroupName, networkSecurityGroupName);

                // List NSG
                listNsgResponse = networkResourceProviderClient.NetworkSecurityGroups.List(resourceGroupName);
                Assert.Equal(0, listNsgResponse.Value.Count);
            }
        }
    }
}