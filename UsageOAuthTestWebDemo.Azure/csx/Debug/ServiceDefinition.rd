<?xml version="1.0" encoding="utf-8"?>
<serviceModel xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema" name="SageNA.CE.MvcApplicationSignOnDemo.Azure" generation="1" functional="0" release="0" Id="1148507a-5f07-409b-8b99-6906846c301e" dslVersion="1.2.0.0" xmlns="http://schemas.microsoft.com/dsltools/RDSM">
  <groups>
    <group name="SageNA.CE.MvcApplicationSignOnDemo.AzureGroup" generation="1" functional="0" release="0">
      <componentports>
        <inPort name="CEWebDemo:Endpoint1" protocol="http">
          <inToChannel>
            <lBChannelMoniker name="/SageNA.CE.MvcApplicationSignOnDemo.Azure/SageNA.CE.MvcApplicationSignOnDemo.AzureGroup/LB:CEWebDemo:Endpoint1" />
          </inToChannel>
        </inPort>
      </componentports>
      <settings>
        <aCS name="CEWebDemo:Microsoft.WindowsAzure.Plugins.Caching.ClientDiagnosticLevel" defaultValue="">
          <maps>
            <mapMoniker name="/SageNA.CE.MvcApplicationSignOnDemo.Azure/SageNA.CE.MvcApplicationSignOnDemo.AzureGroup/MapCEWebDemo:Microsoft.WindowsAzure.Plugins.Caching.ClientDiagnosticLevel" />
          </maps>
        </aCS>
        <aCS name="CEWebDemo:Microsoft.WindowsAzure.Plugins.Diagnostics.ConnectionString" defaultValue="">
          <maps>
            <mapMoniker name="/SageNA.CE.MvcApplicationSignOnDemo.Azure/SageNA.CE.MvcApplicationSignOnDemo.AzureGroup/MapCEWebDemo:Microsoft.WindowsAzure.Plugins.Diagnostics.ConnectionString" />
          </maps>
        </aCS>
        <aCS name="CEWebDemoInstances" defaultValue="[1,1,1]">
          <maps>
            <mapMoniker name="/SageNA.CE.MvcApplicationSignOnDemo.Azure/SageNA.CE.MvcApplicationSignOnDemo.AzureGroup/MapCEWebDemoInstances" />
          </maps>
        </aCS>
      </settings>
      <channels>
        <lBChannel name="LB:CEWebDemo:Endpoint1">
          <toPorts>
            <inPortMoniker name="/SageNA.CE.MvcApplicationSignOnDemo.Azure/SageNA.CE.MvcApplicationSignOnDemo.AzureGroup/CEWebDemo/Endpoint1" />
          </toPorts>
        </lBChannel>
      </channels>
      <maps>
        <map name="MapCEWebDemo:Microsoft.WindowsAzure.Plugins.Caching.ClientDiagnosticLevel" kind="Identity">
          <setting>
            <aCSMoniker name="/SageNA.CE.MvcApplicationSignOnDemo.Azure/SageNA.CE.MvcApplicationSignOnDemo.AzureGroup/CEWebDemo/Microsoft.WindowsAzure.Plugins.Caching.ClientDiagnosticLevel" />
          </setting>
        </map>
        <map name="MapCEWebDemo:Microsoft.WindowsAzure.Plugins.Diagnostics.ConnectionString" kind="Identity">
          <setting>
            <aCSMoniker name="/SageNA.CE.MvcApplicationSignOnDemo.Azure/SageNA.CE.MvcApplicationSignOnDemo.AzureGroup/CEWebDemo/Microsoft.WindowsAzure.Plugins.Diagnostics.ConnectionString" />
          </setting>
        </map>
        <map name="MapCEWebDemoInstances" kind="Identity">
          <setting>
            <sCSPolicyIDMoniker name="/SageNA.CE.MvcApplicationSignOnDemo.Azure/SageNA.CE.MvcApplicationSignOnDemo.AzureGroup/CEWebDemoInstances" />
          </setting>
        </map>
      </maps>
      <components>
        <groupHascomponents>
          <role name="CEWebDemo" generation="1" functional="0" release="0" software="D:\SFAO User Management\CEWebDemo\CEWebDemo\UsageOAuthTestWebDemo.Azure\csx\Debug\roles\CEWebDemo" entryPoint="base\x64\WaHostBootstrapper.exe" parameters="base\x64\WaIISHost.exe " memIndex="1792" hostingEnvironment="frontendadmin" hostingEnvironmentVersion="2">
            <componentports>
              <inPort name="Endpoint1" protocol="http" portRanges="80" />
            </componentports>
            <settings>
              <aCS name="Microsoft.WindowsAzure.Plugins.Caching.ClientDiagnosticLevel" defaultValue="" />
              <aCS name="Microsoft.WindowsAzure.Plugins.Diagnostics.ConnectionString" defaultValue="" />
              <aCS name="__ModelData" defaultValue="&lt;m role=&quot;CEWebDemo&quot; xmlns=&quot;urn:azure:m:v1&quot;&gt;&lt;r name=&quot;CEWebDemo&quot;&gt;&lt;e name=&quot;Endpoint1&quot; /&gt;&lt;/r&gt;&lt;/m&gt;" />
            </settings>
            <resourcereferences>
              <resourceReference name="DiagnosticStore" defaultAmount="[4096,4096,4096]" defaultSticky="true" kind="Directory" />
              <resourceReference name="EventStore" defaultAmount="[1000,1000,1000]" defaultSticky="false" kind="LogStore" />
            </resourcereferences>
          </role>
          <sCSPolicy>
            <sCSPolicyIDMoniker name="/SageNA.CE.MvcApplicationSignOnDemo.Azure/SageNA.CE.MvcApplicationSignOnDemo.AzureGroup/CEWebDemoInstances" />
            <sCSPolicyUpdateDomainMoniker name="/SageNA.CE.MvcApplicationSignOnDemo.Azure/SageNA.CE.MvcApplicationSignOnDemo.AzureGroup/CEWebDemoUpgradeDomains" />
            <sCSPolicyFaultDomainMoniker name="/SageNA.CE.MvcApplicationSignOnDemo.Azure/SageNA.CE.MvcApplicationSignOnDemo.AzureGroup/CEWebDemoFaultDomains" />
          </sCSPolicy>
        </groupHascomponents>
      </components>
      <sCSPolicy>
        <sCSPolicyUpdateDomain name="CEWebDemoUpgradeDomains" defaultPolicy="[5,5,5]" />
        <sCSPolicyFaultDomain name="CEWebDemoFaultDomains" defaultPolicy="[2,2,2]" />
        <sCSPolicyID name="CEWebDemoInstances" defaultPolicy="[1,1,1]" />
      </sCSPolicy>
    </group>
  </groups>
  <implements>
    <implementation Id="8006d76e-c93b-4713-a4b6-f732d20e60f9" ref="Microsoft.RedDog.Contract\ServiceContract\SageNA.CE.MvcApplicationSignOnDemo.AzureContract@ServiceDefinition">
      <interfacereferences>
        <interfaceReference Id="b395be93-affd-48a7-b935-13518860160f" ref="Microsoft.RedDog.Contract\Interface\CEWebDemo:Endpoint1@ServiceDefinition">
          <inPort>
            <inPortMoniker name="/SageNA.CE.MvcApplicationSignOnDemo.Azure/SageNA.CE.MvcApplicationSignOnDemo.AzureGroup/CEWebDemo:Endpoint1" />
          </inPort>
        </interfaceReference>
      </interfacereferences>
    </implementation>
  </implements>
</serviceModel>