// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Batch.Protocol
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for TaskOperations.
    /// </summary>
    public static partial class TaskOperationsExtensions
    {
            /// <summary>
            /// Adds a task to the specified job.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='jobId'>
            /// The ID of the job to which the task is to be added.
            /// </param>
            /// <param name='task'>
            /// The task to be added.
            /// </param>
            /// <param name='taskAddOptions'>
            /// Additional parameters for the operation
            /// </param>
            public static TaskAddHeaders Add(this ITaskOperations operations, string jobId, TaskAddParameter task, TaskAddOptions taskAddOptions = default(TaskAddOptions))
            {
                return operations.AddAsync(jobId, task, taskAddOptions).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Adds a task to the specified job.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='jobId'>
            /// The ID of the job to which the task is to be added.
            /// </param>
            /// <param name='task'>
            /// The task to be added.
            /// </param>
            /// <param name='taskAddOptions'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<TaskAddHeaders> AddAsync(this ITaskOperations operations, string jobId, TaskAddParameter task, TaskAddOptions taskAddOptions = default(TaskAddOptions), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.AddWithHttpMessagesAsync(jobId, task, taskAddOptions, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Headers;
                }
            }

            /// <summary>
            /// Lists all of the tasks that are associated with the specified job.
            /// </summary>
            /// <remarks>
            /// For multi-instance tasks, information such as affinityId, executionInfo and
            /// nodeInfo refer to the primary task. Use the list subtasks API to retrieve
            /// information about subtasks.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='jobId'>
            /// The ID of the job.
            /// </param>
            /// <param name='taskListOptions'>
            /// Additional parameters for the operation
            /// </param>
            public static IPage<CloudTask> List(this ITaskOperations operations, string jobId, TaskListOptions taskListOptions = default(TaskListOptions))
            {
                return operations.ListAsync(jobId, taskListOptions).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all of the tasks that are associated with the specified job.
            /// </summary>
            /// <remarks>
            /// For multi-instance tasks, information such as affinityId, executionInfo and
            /// nodeInfo refer to the primary task. Use the list subtasks API to retrieve
            /// information about subtasks.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='jobId'>
            /// The ID of the job.
            /// </param>
            /// <param name='taskListOptions'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<CloudTask>> ListAsync(this ITaskOperations operations, string jobId, TaskListOptions taskListOptions = default(TaskListOptions), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(jobId, taskListOptions, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Adds a collection of tasks to the specified job.
            /// </summary>
            /// <remarks>
            /// Note that each task must have a unique ID. The Batch service may not return
            /// the results for each task in the same order the tasks were submitted in
            /// this request. If the server times out or the connection is closed during
            /// the request, the request may have been partially or fully processed, or not
            /// at all. In such cases, the user should re-issue the request. Note that it
            /// is up to the user to correctly handle failures when re-issuing a request.
            /// For example, you should use the same task IDs during a retry so that if the
            /// prior operation succeeded, the retry will not create extra tasks
            /// unexpectedly. If the response contains any tasks which failed to add, a
            /// client can retry the request. In a retry, it is most efficient to resubmit
            /// only tasks that failed to add, and to omit tasks that were successfully
            /// added on the first attempt.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='jobId'>
            /// The ID of the job to which the task collection is to be added.
            /// </param>
            /// <param name='value'>
            /// The collection of tasks to add. The total serialized size of this
            /// collection must be less than 4MB. If it is greater than 4MB (for example if
            /// each task has 100's of resource files or environment variables), the
            /// request will fail with code 'RequestBodyTooLarge' and should be retried
            /// again with fewer tasks.
            /// </param>
            /// <param name='taskAddCollectionOptions'>
            /// Additional parameters for the operation
            /// </param>
            public static TaskAddCollectionResult AddCollection(this ITaskOperations operations, string jobId, IList<TaskAddParameter> value, TaskAddCollectionOptions taskAddCollectionOptions = default(TaskAddCollectionOptions))
            {
                return operations.AddCollectionAsync(jobId, value, taskAddCollectionOptions).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Adds a collection of tasks to the specified job.
            /// </summary>
            /// <remarks>
            /// Note that each task must have a unique ID. The Batch service may not return
            /// the results for each task in the same order the tasks were submitted in
            /// this request. If the server times out or the connection is closed during
            /// the request, the request may have been partially or fully processed, or not
            /// at all. In such cases, the user should re-issue the request. Note that it
            /// is up to the user to correctly handle failures when re-issuing a request.
            /// For example, you should use the same task IDs during a retry so that if the
            /// prior operation succeeded, the retry will not create extra tasks
            /// unexpectedly. If the response contains any tasks which failed to add, a
            /// client can retry the request. In a retry, it is most efficient to resubmit
            /// only tasks that failed to add, and to omit tasks that were successfully
            /// added on the first attempt.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='jobId'>
            /// The ID of the job to which the task collection is to be added.
            /// </param>
            /// <param name='value'>
            /// The collection of tasks to add. The total serialized size of this
            /// collection must be less than 4MB. If it is greater than 4MB (for example if
            /// each task has 100's of resource files or environment variables), the
            /// request will fail with code 'RequestBodyTooLarge' and should be retried
            /// again with fewer tasks.
            /// </param>
            /// <param name='taskAddCollectionOptions'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<TaskAddCollectionResult> AddCollectionAsync(this ITaskOperations operations, string jobId, IList<TaskAddParameter> value, TaskAddCollectionOptions taskAddCollectionOptions = default(TaskAddCollectionOptions), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.AddCollectionWithHttpMessagesAsync(jobId, value, taskAddCollectionOptions, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a task from the specified job.
            /// </summary>
            /// <remarks>
            /// When a task is deleted, all of the files in its directory on the compute
            /// node where it ran are also deleted (regardless of the retention time). For
            /// multi-instance tasks, the delete task operation applies synchronously to
            /// the primary task; subtasks and their files are then deleted asynchronously
            /// in the background.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='jobId'>
            /// The ID of the job from which to delete the task.
            /// </param>
            /// <param name='taskId'>
            /// The ID of the task to delete.
            /// </param>
            /// <param name='taskDeleteOptions'>
            /// Additional parameters for the operation
            /// </param>
            public static TaskDeleteHeaders Delete(this ITaskOperations operations, string jobId, string taskId, TaskDeleteOptions taskDeleteOptions = default(TaskDeleteOptions))
            {
                return operations.DeleteAsync(jobId, taskId, taskDeleteOptions).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a task from the specified job.
            /// </summary>
            /// <remarks>
            /// When a task is deleted, all of the files in its directory on the compute
            /// node where it ran are also deleted (regardless of the retention time). For
            /// multi-instance tasks, the delete task operation applies synchronously to
            /// the primary task; subtasks and their files are then deleted asynchronously
            /// in the background.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='jobId'>
            /// The ID of the job from which to delete the task.
            /// </param>
            /// <param name='taskId'>
            /// The ID of the task to delete.
            /// </param>
            /// <param name='taskDeleteOptions'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<TaskDeleteHeaders> DeleteAsync(this ITaskOperations operations, string jobId, string taskId, TaskDeleteOptions taskDeleteOptions = default(TaskDeleteOptions), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.DeleteWithHttpMessagesAsync(jobId, taskId, taskDeleteOptions, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Headers;
                }
            }

            /// <summary>
            /// Gets information about the specified task.
            /// </summary>
            /// <remarks>
            /// For multi-instance tasks, information such as affinityId, executionInfo and
            /// nodeInfo refer to the primary task. Use the list subtasks API to retrieve
            /// information about subtasks.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='jobId'>
            /// The ID of the job that contains the task.
            /// </param>
            /// <param name='taskId'>
            /// The ID of the task to get information about.
            /// </param>
            /// <param name='taskGetOptions'>
            /// Additional parameters for the operation
            /// </param>
            public static CloudTask Get(this ITaskOperations operations, string jobId, string taskId, TaskGetOptions taskGetOptions = default(TaskGetOptions))
            {
                return operations.GetAsync(jobId, taskId, taskGetOptions).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets information about the specified task.
            /// </summary>
            /// <remarks>
            /// For multi-instance tasks, information such as affinityId, executionInfo and
            /// nodeInfo refer to the primary task. Use the list subtasks API to retrieve
            /// information about subtasks.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='jobId'>
            /// The ID of the job that contains the task.
            /// </param>
            /// <param name='taskId'>
            /// The ID of the task to get information about.
            /// </param>
            /// <param name='taskGetOptions'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<CloudTask> GetAsync(this ITaskOperations operations, string jobId, string taskId, TaskGetOptions taskGetOptions = default(TaskGetOptions), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(jobId, taskId, taskGetOptions, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates the properties of the specified task.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='jobId'>
            /// The ID of the job containing the task.
            /// </param>
            /// <param name='taskId'>
            /// The ID of the task to update.
            /// </param>
            /// <param name='constraints'>
            /// Constraints that apply to this task. If omitted, the task is given the
            /// default constraints. For multi-instance tasks, updating the retention time
            /// applies only to the primary task and not subtasks.
            /// </param>
            /// <param name='taskUpdateOptions'>
            /// Additional parameters for the operation
            /// </param>
            public static TaskUpdateHeaders Update(this ITaskOperations operations, string jobId, string taskId, TaskConstraints constraints = default(TaskConstraints), TaskUpdateOptions taskUpdateOptions = default(TaskUpdateOptions))
            {
                return operations.UpdateAsync(jobId, taskId, constraints, taskUpdateOptions).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates the properties of the specified task.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='jobId'>
            /// The ID of the job containing the task.
            /// </param>
            /// <param name='taskId'>
            /// The ID of the task to update.
            /// </param>
            /// <param name='constraints'>
            /// Constraints that apply to this task. If omitted, the task is given the
            /// default constraints. For multi-instance tasks, updating the retention time
            /// applies only to the primary task and not subtasks.
            /// </param>
            /// <param name='taskUpdateOptions'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<TaskUpdateHeaders> UpdateAsync(this ITaskOperations operations, string jobId, string taskId, TaskConstraints constraints = default(TaskConstraints), TaskUpdateOptions taskUpdateOptions = default(TaskUpdateOptions), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(jobId, taskId, constraints, taskUpdateOptions, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Headers;
                }
            }

            /// <summary>
            /// Lists all of the subtasks that are associated with the specified
            /// multi-instance task.
            /// </summary>
            /// <remarks>
            /// If the task is not a multi-instance task then this returns an empty
            /// collection.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='jobId'>
            /// The ID of the job.
            /// </param>
            /// <param name='taskId'>
            /// The ID of the task.
            /// </param>
            /// <param name='taskListSubtasksOptions'>
            /// Additional parameters for the operation
            /// </param>
            public static CloudTaskListSubtasksResult ListSubtasks(this ITaskOperations operations, string jobId, string taskId, TaskListSubtasksOptions taskListSubtasksOptions = default(TaskListSubtasksOptions))
            {
                return operations.ListSubtasksAsync(jobId, taskId, taskListSubtasksOptions).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all of the subtasks that are associated with the specified
            /// multi-instance task.
            /// </summary>
            /// <remarks>
            /// If the task is not a multi-instance task then this returns an empty
            /// collection.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='jobId'>
            /// The ID of the job.
            /// </param>
            /// <param name='taskId'>
            /// The ID of the task.
            /// </param>
            /// <param name='taskListSubtasksOptions'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<CloudTaskListSubtasksResult> ListSubtasksAsync(this ITaskOperations operations, string jobId, string taskId, TaskListSubtasksOptions taskListSubtasksOptions = default(TaskListSubtasksOptions), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListSubtasksWithHttpMessagesAsync(jobId, taskId, taskListSubtasksOptions, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Terminates the specified task.
            /// </summary>
            /// <remarks>
            /// When the task has been terminated, it moves to the completed state. For
            /// multi-instance tasks, the terminate task operation applies synchronously to
            /// the primary task; subtasks are then terminated asynchronously in the
            /// background.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='jobId'>
            /// The ID of the job containing the task.
            /// </param>
            /// <param name='taskId'>
            /// The ID of the task to terminate.
            /// </param>
            /// <param name='taskTerminateOptions'>
            /// Additional parameters for the operation
            /// </param>
            public static TaskTerminateHeaders Terminate(this ITaskOperations operations, string jobId, string taskId, TaskTerminateOptions taskTerminateOptions = default(TaskTerminateOptions))
            {
                return operations.TerminateAsync(jobId, taskId, taskTerminateOptions).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Terminates the specified task.
            /// </summary>
            /// <remarks>
            /// When the task has been terminated, it moves to the completed state. For
            /// multi-instance tasks, the terminate task operation applies synchronously to
            /// the primary task; subtasks are then terminated asynchronously in the
            /// background.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='jobId'>
            /// The ID of the job containing the task.
            /// </param>
            /// <param name='taskId'>
            /// The ID of the task to terminate.
            /// </param>
            /// <param name='taskTerminateOptions'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<TaskTerminateHeaders> TerminateAsync(this ITaskOperations operations, string jobId, string taskId, TaskTerminateOptions taskTerminateOptions = default(TaskTerminateOptions), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.TerminateWithHttpMessagesAsync(jobId, taskId, taskTerminateOptions, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Headers;
                }
            }

            /// <summary>
            /// Reactivates a task, allowing it to run again even if its retry count has
            /// been exhausted.
            /// </summary>
            /// <remarks>
            /// Reactivation makes a task eligible to be retried again up to its maximum
            /// retry count. The task's state is changed to active. As the task is no
            /// longer in the completed state, any previous exit code or failure
            /// information is no longer available after reactivation. Each time a task is
            /// reactivated, its retry count is reset to 0. Reactivation will fail for
            /// tasks that are not completed or that previously completed successfully
            /// (with an exit code of 0). Additionally, it will fail if the job has
            /// completed (or is terminating or deleting).
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='jobId'>
            /// The ID of the job containing the task.
            /// </param>
            /// <param name='taskId'>
            /// The ID of the task to reactivate.
            /// </param>
            /// <param name='taskReactivateOptions'>
            /// Additional parameters for the operation
            /// </param>
            public static TaskReactivateHeaders Reactivate(this ITaskOperations operations, string jobId, string taskId, TaskReactivateOptions taskReactivateOptions = default(TaskReactivateOptions))
            {
                return operations.ReactivateAsync(jobId, taskId, taskReactivateOptions).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Reactivates a task, allowing it to run again even if its retry count has
            /// been exhausted.
            /// </summary>
            /// <remarks>
            /// Reactivation makes a task eligible to be retried again up to its maximum
            /// retry count. The task's state is changed to active. As the task is no
            /// longer in the completed state, any previous exit code or failure
            /// information is no longer available after reactivation. Each time a task is
            /// reactivated, its retry count is reset to 0. Reactivation will fail for
            /// tasks that are not completed or that previously completed successfully
            /// (with an exit code of 0). Additionally, it will fail if the job has
            /// completed (or is terminating or deleting).
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='jobId'>
            /// The ID of the job containing the task.
            /// </param>
            /// <param name='taskId'>
            /// The ID of the task to reactivate.
            /// </param>
            /// <param name='taskReactivateOptions'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<TaskReactivateHeaders> ReactivateAsync(this ITaskOperations operations, string jobId, string taskId, TaskReactivateOptions taskReactivateOptions = default(TaskReactivateOptions), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ReactivateWithHttpMessagesAsync(jobId, taskId, taskReactivateOptions, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Headers;
                }
            }

            /// <summary>
            /// Lists all of the tasks that are associated with the specified job.
            /// </summary>
            /// <remarks>
            /// For multi-instance tasks, information such as affinityId, executionInfo and
            /// nodeInfo refer to the primary task. Use the list subtasks API to retrieve
            /// information about subtasks.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='taskListNextOptions'>
            /// Additional parameters for the operation
            /// </param>
            public static IPage<CloudTask> ListNext(this ITaskOperations operations, string nextPageLink, TaskListNextOptions taskListNextOptions = default(TaskListNextOptions))
            {
                return operations.ListNextAsync(nextPageLink, taskListNextOptions).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all of the tasks that are associated with the specified job.
            /// </summary>
            /// <remarks>
            /// For multi-instance tasks, information such as affinityId, executionInfo and
            /// nodeInfo refer to the primary task. Use the list subtasks API to retrieve
            /// information about subtasks.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='taskListNextOptions'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<CloudTask>> ListNextAsync(this ITaskOperations operations, string nextPageLink, TaskListNextOptions taskListNextOptions = default(TaskListNextOptions), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, taskListNextOptions, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}