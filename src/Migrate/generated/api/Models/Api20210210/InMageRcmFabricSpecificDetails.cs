namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Extensions;

    /// <summary>InMageRcm fabric specific details.</summary>
    public partial class InMageRcmFabricSpecificDetails :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFabricSpecificDetails,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFabricSpecificDetailsInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IFabricSpecificDetails"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IFabricSpecificDetails __fabricSpecificDetails = new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.FabricSpecificDetails();

        /// <summary>Backing field for <see cref="AgentDetail" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IAgentDetails[] _agentDetail;

        /// <summary>The list of agent details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IAgentDetails[] AgentDetail { get => this._agentDetail; }

        /// <summary>Backing field for <see cref="ControlPlaneUri" /> property.</summary>
        private string _controlPlaneUri;

        /// <summary>The control plane Uri.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string ControlPlaneUri { get => this._controlPlaneUri; }

        /// <summary>Backing field for <see cref="DataPlaneUri" /> property.</summary>
        private string _dataPlaneUri;

        /// <summary>The data plane Uri.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string DataPlaneUri { get => this._dataPlaneUri; }

        /// <summary>Backing field for <see cref="Dra" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IDraDetails[] _dra;

        /// <summary>The list of DRAs.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IDraDetails[] Dra { get => this._dra; }

        /// <summary>Gets the class type. Overridden in derived classes.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inherited)]
        public string InstanceType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IFabricSpecificDetailsInternal)__fabricSpecificDetails).InstanceType; }

        /// <summary>Backing field for <see cref="MarsAgent" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IMarsAgentDetails[] _marsAgent;

        /// <summary>The list of Mars agents.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IMarsAgentDetails[] MarsAgent { get => this._marsAgent; }

        /// <summary>Internal Acessors for InstanceType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IFabricSpecificDetailsInternal.InstanceType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IFabricSpecificDetailsInternal)__fabricSpecificDetails).InstanceType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IFabricSpecificDetailsInternal)__fabricSpecificDetails).InstanceType = value; }

        /// <summary>Internal Acessors for AgentDetail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IAgentDetails[] Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFabricSpecificDetailsInternal.AgentDetail { get => this._agentDetail; set { {_agentDetail = value;} } }

        /// <summary>Internal Acessors for ControlPlaneUri</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFabricSpecificDetailsInternal.ControlPlaneUri { get => this._controlPlaneUri; set { {_controlPlaneUri = value;} } }

        /// <summary>Internal Acessors for DataPlaneUri</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFabricSpecificDetailsInternal.DataPlaneUri { get => this._dataPlaneUri; set { {_dataPlaneUri = value;} } }

        /// <summary>Internal Acessors for Dra</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IDraDetails[] Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFabricSpecificDetailsInternal.Dra { get => this._dra; set { {_dra = value;} } }

        /// <summary>Internal Acessors for MarsAgent</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IMarsAgentDetails[] Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFabricSpecificDetailsInternal.MarsAgent { get => this._marsAgent; set { {_marsAgent = value;} } }

        /// <summary>Internal Acessors for PhysicalSiteId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFabricSpecificDetailsInternal.PhysicalSiteId { get => this._physicalSiteId; set { {_physicalSiteId = value;} } }

        /// <summary>Internal Acessors for ProcessServer</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProcessServerDetails[] Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFabricSpecificDetailsInternal.ProcessServer { get => this._processServer; set { {_processServer = value;} } }

        /// <summary>Internal Acessors for PushInstaller</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IPushInstallerDetails[] Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFabricSpecificDetailsInternal.PushInstaller { get => this._pushInstaller; set { {_pushInstaller = value;} } }

        /// <summary>Internal Acessors for RcmProxy</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRcmProxyDetails[] Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFabricSpecificDetailsInternal.RcmProxy { get => this._rcmProxy; set { {_rcmProxy = value;} } }

        /// <summary>Internal Acessors for ReplicationAgent</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IReplicationAgentDetails[] Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFabricSpecificDetailsInternal.ReplicationAgent { get => this._replicationAgent; set { {_replicationAgent = value;} } }

        /// <summary>Internal Acessors for ReprotectAgent</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IReprotectAgentDetails[] Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFabricSpecificDetailsInternal.ReprotectAgent { get => this._reprotectAgent; set { {_reprotectAgent = value;} } }

        /// <summary>Internal Acessors for ServiceContainerId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFabricSpecificDetailsInternal.ServiceContainerId { get => this._serviceContainerId; set { {_serviceContainerId = value;} } }

        /// <summary>Internal Acessors for ServiceEndpoint</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFabricSpecificDetailsInternal.ServiceEndpoint { get => this._serviceEndpoint; set { {_serviceEndpoint = value;} } }

        /// <summary>Internal Acessors for ServiceResourceId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFabricSpecificDetailsInternal.ServiceResourceId { get => this._serviceResourceId; set { {_serviceResourceId = value;} } }

        /// <summary>Internal Acessors for VmwareSiteId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFabricSpecificDetailsInternal.VmwareSiteId { get => this._vmwareSiteId; set { {_vmwareSiteId = value;} } }

        /// <summary>Backing field for <see cref="PhysicalSiteId" /> property.</summary>
        private string _physicalSiteId;

        /// <summary>The ARM Id of the physical site.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string PhysicalSiteId { get => this._physicalSiteId; }

        /// <summary>Backing field for <see cref="ProcessServer" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProcessServerDetails[] _processServer;

        /// <summary>The list of process servers.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProcessServerDetails[] ProcessServer { get => this._processServer; }

        /// <summary>Backing field for <see cref="PushInstaller" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IPushInstallerDetails[] _pushInstaller;

        /// <summary>The list of push installers.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IPushInstallerDetails[] PushInstaller { get => this._pushInstaller; }

        /// <summary>Backing field for <see cref="RcmProxy" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRcmProxyDetails[] _rcmProxy;

        /// <summary>The list of RCM proxies.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRcmProxyDetails[] RcmProxy { get => this._rcmProxy; }

        /// <summary>Backing field for <see cref="ReplicationAgent" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IReplicationAgentDetails[] _replicationAgent;

        /// <summary>The list of replication agents.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IReplicationAgentDetails[] ReplicationAgent { get => this._replicationAgent; }

        /// <summary>Backing field for <see cref="ReprotectAgent" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IReprotectAgentDetails[] _reprotectAgent;

        /// <summary>The list of reprotect agents.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IReprotectAgentDetails[] ReprotectAgent { get => this._reprotectAgent; }

        /// <summary>Backing field for <see cref="ServiceContainerId" /> property.</summary>
        private string _serviceContainerId;

        /// <summary>The service container Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string ServiceContainerId { get => this._serviceContainerId; }

        /// <summary>Backing field for <see cref="ServiceEndpoint" /> property.</summary>
        private string _serviceEndpoint;

        /// <summary>The service endpoint.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string ServiceEndpoint { get => this._serviceEndpoint; }

        /// <summary>Backing field for <see cref="ServiceResourceId" /> property.</summary>
        private string _serviceResourceId;

        /// <summary>The service resource Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string ServiceResourceId { get => this._serviceResourceId; }

        /// <summary>Backing field for <see cref="VmwareSiteId" /> property.</summary>
        private string _vmwareSiteId;

        /// <summary>The ARM Id of the VMware site.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string VmwareSiteId { get => this._vmwareSiteId; }

        /// <summary>Creates an new <see cref="InMageRcmFabricSpecificDetails" /> instance.</summary>
        public InMageRcmFabricSpecificDetails()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A < see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__fabricSpecificDetails), __fabricSpecificDetails);
            await eventListener.AssertObjectIsValid(nameof(__fabricSpecificDetails), __fabricSpecificDetails);
        }
    }
    /// InMageRcm fabric specific details.
    public partial interface IInMageRcmFabricSpecificDetails :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IFabricSpecificDetails
    {
        /// <summary>The list of agent details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The list of agent details.",
        SerializedName = @"agentDetails",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IAgentDetails) })]
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IAgentDetails[] AgentDetail { get;  }
        /// <summary>The control plane Uri.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The control plane Uri.",
        SerializedName = @"controlPlaneUri",
        PossibleTypes = new [] { typeof(string) })]
        string ControlPlaneUri { get;  }
        /// <summary>The data plane Uri.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The data plane Uri.",
        SerializedName = @"dataPlaneUri",
        PossibleTypes = new [] { typeof(string) })]
        string DataPlaneUri { get;  }
        /// <summary>The list of DRAs.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The list of DRAs.",
        SerializedName = @"dras",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IDraDetails) })]
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IDraDetails[] Dra { get;  }
        /// <summary>The list of Mars agents.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The list of Mars agents.",
        SerializedName = @"marsAgents",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IMarsAgentDetails) })]
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IMarsAgentDetails[] MarsAgent { get;  }
        /// <summary>The ARM Id of the physical site.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The ARM Id of the physical site.",
        SerializedName = @"physicalSiteId",
        PossibleTypes = new [] { typeof(string) })]
        string PhysicalSiteId { get;  }
        /// <summary>The list of process servers.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The list of process servers.",
        SerializedName = @"processServers",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProcessServerDetails) })]
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProcessServerDetails[] ProcessServer { get;  }
        /// <summary>The list of push installers.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The list of push installers.",
        SerializedName = @"pushInstallers",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IPushInstallerDetails) })]
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IPushInstallerDetails[] PushInstaller { get;  }
        /// <summary>The list of RCM proxies.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The list of RCM proxies.",
        SerializedName = @"rcmProxies",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRcmProxyDetails) })]
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRcmProxyDetails[] RcmProxy { get;  }
        /// <summary>The list of replication agents.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The list of replication agents.",
        SerializedName = @"replicationAgents",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IReplicationAgentDetails) })]
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IReplicationAgentDetails[] ReplicationAgent { get;  }
        /// <summary>The list of reprotect agents.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The list of reprotect agents.",
        SerializedName = @"reprotectAgents",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IReprotectAgentDetails) })]
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IReprotectAgentDetails[] ReprotectAgent { get;  }
        /// <summary>The service container Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The service container Id.",
        SerializedName = @"serviceContainerId",
        PossibleTypes = new [] { typeof(string) })]
        string ServiceContainerId { get;  }
        /// <summary>The service endpoint.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The service endpoint.",
        SerializedName = @"serviceEndpoint",
        PossibleTypes = new [] { typeof(string) })]
        string ServiceEndpoint { get;  }
        /// <summary>The service resource Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The service resource Id.",
        SerializedName = @"serviceResourceId",
        PossibleTypes = new [] { typeof(string) })]
        string ServiceResourceId { get;  }
        /// <summary>The ARM Id of the VMware site.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The ARM Id of the VMware site.",
        SerializedName = @"vmwareSiteId",
        PossibleTypes = new [] { typeof(string) })]
        string VmwareSiteId { get;  }

    }
    /// InMageRcm fabric specific details.
    internal partial interface IInMageRcmFabricSpecificDetailsInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IFabricSpecificDetailsInternal
    {
        /// <summary>The list of agent details.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IAgentDetails[] AgentDetail { get; set; }
        /// <summary>The control plane Uri.</summary>
        string ControlPlaneUri { get; set; }
        /// <summary>The data plane Uri.</summary>
        string DataPlaneUri { get; set; }
        /// <summary>The list of DRAs.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IDraDetails[] Dra { get; set; }
        /// <summary>The list of Mars agents.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IMarsAgentDetails[] MarsAgent { get; set; }
        /// <summary>The ARM Id of the physical site.</summary>
        string PhysicalSiteId { get; set; }
        /// <summary>The list of process servers.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProcessServerDetails[] ProcessServer { get; set; }
        /// <summary>The list of push installers.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IPushInstallerDetails[] PushInstaller { get; set; }
        /// <summary>The list of RCM proxies.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRcmProxyDetails[] RcmProxy { get; set; }
        /// <summary>The list of replication agents.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IReplicationAgentDetails[] ReplicationAgent { get; set; }
        /// <summary>The list of reprotect agents.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IReprotectAgentDetails[] ReprotectAgent { get; set; }
        /// <summary>The service container Id.</summary>
        string ServiceContainerId { get; set; }
        /// <summary>The service endpoint.</summary>
        string ServiceEndpoint { get; set; }
        /// <summary>The service resource Id.</summary>
        string ServiceResourceId { get; set; }
        /// <summary>The ARM Id of the VMware site.</summary>
        string VmwareSiteId { get; set; }

    }
}