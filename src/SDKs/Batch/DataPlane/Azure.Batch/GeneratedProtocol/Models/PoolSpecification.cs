// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Batch;
    using Microsoft.Azure.Batch.Protocol;
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Specification for creating a new pool.
    /// </summary>
    public partial class PoolSpecification
    {
        /// <summary>
        /// Initializes a new instance of the PoolSpecification class.
        /// </summary>
        public PoolSpecification()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PoolSpecification class.
        /// </summary>
        /// <param name="vmSize">The size of the virtual machines in the pool.
        /// All virtual machines in a pool are the same size.</param>
        /// <param name="displayName">The display name for the pool.</param>
        /// <param name="cloudServiceConfiguration">The cloud service
        /// configuration for the pool.</param>
        /// <param name="virtualMachineConfiguration">The virtual machine
        /// configuration for the pool.</param>
        /// <param name="maxTasksPerNode">The maximum number of tasks that can
        /// run concurrently on a single compute node in the pool.</param>
        /// <param name="taskSchedulingPolicy">How tasks are distributed across
        /// compute nodes in a pool.</param>
        /// <param name="resizeTimeout">The timeout for allocation of compute
        /// nodes to the pool.</param>
        /// <param name="targetDedicatedNodes">The desired number of dedicated
        /// compute nodes in the pool.</param>
        /// <param name="targetLowPriorityNodes">The desired number of
        /// low-priority compute nodes in the pool.</param>
        /// <param name="enableAutoScale">Whether the pool size should
        /// automatically adjust over time.</param>
        /// <param name="autoScaleFormula">The formula for the desired number
        /// of compute nodes in the pool.</param>
        /// <param name="autoScaleEvaluationInterval">The time interval at
        /// which to automatically adjust the pool size according to the
        /// autoscale formula.</param>
        /// <param name="enableInterNodeCommunication">Whether the pool permits
        /// direct communication between nodes.</param>
        /// <param name="networkConfiguration">The network configuration for
        /// the pool.</param>
        /// <param name="startTask">A task to run on each compute node as it
        /// joins the pool. The task runs when the node is added to the pool or
        /// when the node is restarted.</param>
        /// <param name="certificateReferences">A list of certificates to be
        /// installed on each compute node in the pool.</param>
        /// <param name="applicationPackageReferences">The list of application
        /// packages to be installed on each compute node in the pool.</param>
        /// <param name="applicationLicenses">The list of application licenses
        /// the Batch service will make available on each compute node in the
        /// pool.</param>
        /// <param name="userAccounts">The list of user accounts to be created
        /// on each node in the pool.</param>
        /// <param name="metadata">A list of name-value pairs associated with
        /// the pool as metadata.</param>
        public PoolSpecification(string vmSize, string displayName = default(string), CloudServiceConfiguration cloudServiceConfiguration = default(CloudServiceConfiguration), VirtualMachineConfiguration virtualMachineConfiguration = default(VirtualMachineConfiguration), int? maxTasksPerNode = default(int?), TaskSchedulingPolicy taskSchedulingPolicy = default(TaskSchedulingPolicy), System.TimeSpan? resizeTimeout = default(System.TimeSpan?), int? targetDedicatedNodes = default(int?), int? targetLowPriorityNodes = default(int?), bool? enableAutoScale = default(bool?), string autoScaleFormula = default(string), System.TimeSpan? autoScaleEvaluationInterval = default(System.TimeSpan?), bool? enableInterNodeCommunication = default(bool?), NetworkConfiguration networkConfiguration = default(NetworkConfiguration), StartTask startTask = default(StartTask), IList<CertificateReference> certificateReferences = default(IList<CertificateReference>), IList<ApplicationPackageReference> applicationPackageReferences = default(IList<ApplicationPackageReference>), IList<string> applicationLicenses = default(IList<string>), IList<UserAccount> userAccounts = default(IList<UserAccount>), IList<MetadataItem> metadata = default(IList<MetadataItem>))
        {
            DisplayName = displayName;
            VmSize = vmSize;
            CloudServiceConfiguration = cloudServiceConfiguration;
            VirtualMachineConfiguration = virtualMachineConfiguration;
            MaxTasksPerNode = maxTasksPerNode;
            TaskSchedulingPolicy = taskSchedulingPolicy;
            ResizeTimeout = resizeTimeout;
            TargetDedicatedNodes = targetDedicatedNodes;
            TargetLowPriorityNodes = targetLowPriorityNodes;
            EnableAutoScale = enableAutoScale;
            AutoScaleFormula = autoScaleFormula;
            AutoScaleEvaluationInterval = autoScaleEvaluationInterval;
            EnableInterNodeCommunication = enableInterNodeCommunication;
            NetworkConfiguration = networkConfiguration;
            StartTask = startTask;
            CertificateReferences = certificateReferences;
            ApplicationPackageReferences = applicationPackageReferences;
            ApplicationLicenses = applicationLicenses;
            UserAccounts = userAccounts;
            Metadata = metadata;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the display name for the pool.
        /// </summary>
        /// <remarks>
        /// The display name need not be unique and can contain any Unicode
        /// characters up to a maximum length of 1024.
        /// </remarks>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets the size of the virtual machines in the pool. All
        /// virtual machines in a pool are the same size.
        /// </summary>
        /// <remarks>
        /// For information about available sizes of virtual machines for Cloud
        /// Services pools (pools created with cloudServiceConfiguration), see
        /// Sizes for Cloud Services
        /// (http://azure.microsoft.com/documentation/articles/cloud-services-sizes-specs/).
        /// Batch supports all Cloud Services VM sizes except ExtraSmall, A1V2
        /// and A2V2. For information about available VM sizes for pools using
        /// images from the Virtual Machines Marketplace (pools created with
        /// virtualMachineConfiguration) see Sizes for Virtual Machines (Linux)
        /// (https://azure.microsoft.com/documentation/articles/virtual-machines-linux-sizes/)
        /// or Sizes for Virtual Machines (Windows)
        /// (https://azure.microsoft.com/documentation/articles/virtual-machines-windows-sizes/).
        /// Batch supports all Azure VM sizes except STANDARD_A0 and those with
        /// premium storage (STANDARD_GS, STANDARD_DS, and STANDARD_DSV2
        /// series).
        /// </remarks>
        [JsonProperty(PropertyName = "vmSize")]
        public string VmSize { get; set; }

        /// <summary>
        /// Gets or sets the cloud service configuration for the pool.
        /// </summary>
        /// <remarks>
        /// This property must be specified if the pool needs to be created
        /// with Azure PaaS VMs. This property and virtualMachineConfiguration
        /// are mutually exclusive and one of the properties must be specified.
        /// If neither is specified then the Batch service returns an error; if
        /// you are calling the REST API directly, the HTTP status code is 400
        /// (Bad Request). This property cannot be specified if the Batch
        /// account was created with its poolAllocationMode property set to
        /// 'UserSubscription'.
        /// </remarks>
        [JsonProperty(PropertyName = "cloudServiceConfiguration")]
        public CloudServiceConfiguration CloudServiceConfiguration { get; set; }

        /// <summary>
        /// Gets or sets the virtual machine configuration for the pool.
        /// </summary>
        /// <remarks>
        /// This property must be specified if the pool needs to be created
        /// with Azure IaaS VMs. This property and cloudServiceConfiguration
        /// are mutually exclusive and one of the properties must be specified.
        /// If neither is specified then the Batch service returns an error; if
        /// you are calling the REST API directly, the HTTP status code is 400
        /// (Bad Request).
        /// </remarks>
        [JsonProperty(PropertyName = "virtualMachineConfiguration")]
        public VirtualMachineConfiguration VirtualMachineConfiguration { get; set; }

        /// <summary>
        /// Gets or sets the maximum number of tasks that can run concurrently
        /// on a single compute node in the pool.
        /// </summary>
        /// <remarks>
        /// The default value is 1. The maximum value of this setting depends
        /// on the size of the compute nodes in the pool (the vmSize setting).
        /// </remarks>
        [JsonProperty(PropertyName = "maxTasksPerNode")]
        public int? MaxTasksPerNode { get; set; }

        /// <summary>
        /// Gets or sets how tasks are distributed across compute nodes in a
        /// pool.
        /// </summary>
        [JsonProperty(PropertyName = "taskSchedulingPolicy")]
        public TaskSchedulingPolicy TaskSchedulingPolicy { get; set; }

        /// <summary>
        /// Gets or sets the timeout for allocation of compute nodes to the
        /// pool.
        /// </summary>
        /// <remarks>
        /// This timeout applies only to manual scaling; it has no effect when
        /// enableAutoScale is set to true. The default value is 15 minutes.
        /// The minimum value is 5 minutes. If you specify a value less than 5
        /// minutes, the Batch service rejects the request with an error; if
        /// you are calling the REST API directly, the HTTP status code is 400
        /// (Bad Request).
        /// </remarks>
        [JsonProperty(PropertyName = "resizeTimeout")]
        public System.TimeSpan? ResizeTimeout { get; set; }

        /// <summary>
        /// Gets or sets the desired number of dedicated compute nodes in the
        /// pool.
        /// </summary>
        /// <remarks>
        /// This property must not be specified if enableAutoScale is set to
        /// true. If enableAutoScale is set to false, then you must set either
        /// targetDedicatedNodes, targetLowPriorityNodes, or both.
        /// </remarks>
        [JsonProperty(PropertyName = "targetDedicatedNodes")]
        public int? TargetDedicatedNodes { get; set; }

        /// <summary>
        /// Gets or sets the desired number of low-priority compute nodes in
        /// the pool.
        /// </summary>
        /// <remarks>
        /// This property must not be specified if enableAutoScale is set to
        /// true. If enableAutoScale is set to false, then you must set either
        /// targetDedicatedNodes, targetLowPriorityNodes, or both.
        /// </remarks>
        [JsonProperty(PropertyName = "targetLowPriorityNodes")]
        public int? TargetLowPriorityNodes { get; set; }

        /// <summary>
        /// Gets or sets whether the pool size should automatically adjust over
        /// time.
        /// </summary>
        /// <remarks>
        /// If false, at least one of targetDedicateNodes and
        /// targetLowPriorityNodes must be specified. If true, the
        /// autoScaleFormula element is required. The pool automatically
        /// resizes according to the formula. The default value is false.
        /// </remarks>
        [JsonProperty(PropertyName = "enableAutoScale")]
        public bool? EnableAutoScale { get; set; }

        /// <summary>
        /// Gets or sets the formula for the desired number of compute nodes in
        /// the pool.
        /// </summary>
        /// <remarks>
        /// This property must not be specified if enableAutoScale is set to
        /// false. It is required if enableAutoScale is set to true. The
        /// formula is checked for validity before the pool is created. If the
        /// formula is not valid, the Batch service rejects the request with
        /// detailed error information.
        /// </remarks>
        [JsonProperty(PropertyName = "autoScaleFormula")]
        public string AutoScaleFormula { get; set; }

        /// <summary>
        /// Gets or sets the time interval at which to automatically adjust the
        /// pool size according to the autoscale formula.
        /// </summary>
        /// <remarks>
        /// The default value is 15 minutes. The minimum and maximum value are
        /// 5 minutes and 168 hours respectively. If you specify a value less
        /// than 5 minutes or greater than 168 hours, the Batch service rejects
        /// the request with an invalid property value error; if you are
        /// calling the REST API directly, the HTTP status code is 400 (Bad
        /// Request).
        /// </remarks>
        [JsonProperty(PropertyName = "autoScaleEvaluationInterval")]
        public System.TimeSpan? AutoScaleEvaluationInterval { get; set; }

        /// <summary>
        /// Gets or sets whether the pool permits direct communication between
        /// nodes.
        /// </summary>
        /// <remarks>
        /// Enabling inter-node communication limits the maximum size of the
        /// pool due to deployment restrictions on the nodes of the pool. This
        /// may result in the pool not reaching its desired size. The default
        /// value is false.
        /// </remarks>
        [JsonProperty(PropertyName = "enableInterNodeCommunication")]
        public bool? EnableInterNodeCommunication { get; set; }

        /// <summary>
        /// Gets or sets the network configuration for the pool.
        /// </summary>
        [JsonProperty(PropertyName = "networkConfiguration")]
        public NetworkConfiguration NetworkConfiguration { get; set; }

        /// <summary>
        /// Gets or sets a task to run on each compute node as it joins the
        /// pool. The task runs when the node is added to the pool or when the
        /// node is restarted.
        /// </summary>
        [JsonProperty(PropertyName = "startTask")]
        public StartTask StartTask { get; set; }

        /// <summary>
        /// Gets or sets a list of certificates to be installed on each compute
        /// node in the pool.
        /// </summary>
        /// <remarks>
        /// For Windows compute nodes, the Batch service installs the
        /// certificates to the specified certificate store and location. For
        /// Linux compute nodes, the certificates are stored in a directory
        /// inside the task working directory and an environment variable
        /// AZ_BATCH_CERTIFICATES_DIR is supplied to the task to query for this
        /// location. For certificates with visibility of 'remoteUser', a
        /// 'certs' directory is created in the user's home directory (e.g.,
        /// /home/{user-name}/certs) and certificates are placed in that
        /// directory.
        /// </remarks>
        [JsonProperty(PropertyName = "certificateReferences")]
        public IList<CertificateReference> CertificateReferences { get; set; }

        /// <summary>
        /// Gets or sets the list of application packages to be installed on
        /// each compute node in the pool.
        /// </summary>
        [JsonProperty(PropertyName = "applicationPackageReferences")]
        public IList<ApplicationPackageReference> ApplicationPackageReferences { get; set; }

        /// <summary>
        /// Gets or sets the list of application licenses the Batch service
        /// will make available on each compute node in the pool.
        /// </summary>
        /// <remarks>
        /// The list of application licenses must be a subset of available
        /// Batch service application licenses. If a license is requested which
        /// is not supported, pool creation will fail.
        /// </remarks>
        [JsonProperty(PropertyName = "applicationLicenses")]
        public IList<string> ApplicationLicenses { get; set; }

        /// <summary>
        /// Gets or sets the list of user accounts to be created on each node
        /// in the pool.
        /// </summary>
        [JsonProperty(PropertyName = "userAccounts")]
        public IList<UserAccount> UserAccounts { get; set; }

        /// <summary>
        /// Gets or sets a list of name-value pairs associated with the pool as
        /// metadata.
        /// </summary>
        /// <remarks>
        /// The Batch service does not assign any meaning to metadata; it is
        /// solely for the use of user code.
        /// </remarks>
        [JsonProperty(PropertyName = "metadata")]
        public IList<MetadataItem> Metadata { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (VmSize == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "VmSize");
            }
            if (CloudServiceConfiguration != null)
            {
                CloudServiceConfiguration.Validate();
            }
            if (VirtualMachineConfiguration != null)
            {
                VirtualMachineConfiguration.Validate();
            }
            if (TaskSchedulingPolicy != null)
            {
                TaskSchedulingPolicy.Validate();
            }
            if (NetworkConfiguration != null)
            {
                NetworkConfiguration.Validate();
            }
            if (StartTask != null)
            {
                StartTask.Validate();
            }
            if (CertificateReferences != null)
            {
                foreach (var element in CertificateReferences)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (ApplicationPackageReferences != null)
            {
                foreach (var element1 in ApplicationPackageReferences)
                {
                    if (element1 != null)
                    {
                        element1.Validate();
                    }
                }
            }
            if (UserAccounts != null)
            {
                foreach (var element2 in UserAccounts)
                {
                    if (element2 != null)
                    {
                        element2.Validate();
                    }
                }
            }
            if (Metadata != null)
            {
                foreach (var element3 in Metadata)
                {
                    if (element3 != null)
                    {
                        element3.Validate();
                    }
                }
            }
        }
    }
}
