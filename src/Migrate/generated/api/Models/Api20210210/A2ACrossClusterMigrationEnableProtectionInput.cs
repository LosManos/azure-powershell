namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Extensions;

    /// <summary>A2A Cross-Cluster Migration enable protection input.</summary>
    public partial class A2ACrossClusterMigrationEnableProtectionInput :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2ACrossClusterMigrationEnableProtectionInput,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2ACrossClusterMigrationEnableProtectionInputInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IEnableProtectionProviderSpecificInput"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IEnableProtectionProviderSpecificInput __enableProtectionProviderSpecificInput = new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.EnableProtectionProviderSpecificInput();

        /// <summary>Backing field for <see cref="FabricObjectId" /> property.</summary>
        private string _fabricObjectId;

        /// <summary>The fabric specific object Id of the virtual machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string FabricObjectId { get => this._fabricObjectId; set => this._fabricObjectId = value; }

        /// <summary>The class type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inherited)]
        public string InstanceType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IEnableProtectionProviderSpecificInputInternal)__enableProtectionProviderSpecificInput).InstanceType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IEnableProtectionProviderSpecificInputInternal)__enableProtectionProviderSpecificInput).InstanceType = value ?? null; }

        /// <summary>Backing field for <see cref="RecoveryContainerId" /> property.</summary>
        private string _recoveryContainerId;

        /// <summary>The recovery container Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string RecoveryContainerId { get => this._recoveryContainerId; set => this._recoveryContainerId = value; }

        /// <summary>
        /// Creates an new <see cref="A2ACrossClusterMigrationEnableProtectionInput" /> instance.
        /// </summary>
        public A2ACrossClusterMigrationEnableProtectionInput()
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
            await eventListener.AssertNotNull(nameof(__enableProtectionProviderSpecificInput), __enableProtectionProviderSpecificInput);
            await eventListener.AssertObjectIsValid(nameof(__enableProtectionProviderSpecificInput), __enableProtectionProviderSpecificInput);
        }
    }
    /// A2A Cross-Cluster Migration enable protection input.
    public partial interface IA2ACrossClusterMigrationEnableProtectionInput :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IEnableProtectionProviderSpecificInput
    {
        /// <summary>The fabric specific object Id of the virtual machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The fabric specific object Id of the virtual machine.",
        SerializedName = @"fabricObjectId",
        PossibleTypes = new [] { typeof(string) })]
        string FabricObjectId { get; set; }
        /// <summary>The recovery container Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The recovery container Id.",
        SerializedName = @"recoveryContainerId",
        PossibleTypes = new [] { typeof(string) })]
        string RecoveryContainerId { get; set; }

    }
    /// A2A Cross-Cluster Migration enable protection input.
    internal partial interface IA2ACrossClusterMigrationEnableProtectionInputInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IEnableProtectionProviderSpecificInputInternal
    {
        /// <summary>The fabric specific object Id of the virtual machine.</summary>
        string FabricObjectId { get; set; }
        /// <summary>The recovery container Id.</summary>
        string RecoveryContainerId { get; set; }

    }
}