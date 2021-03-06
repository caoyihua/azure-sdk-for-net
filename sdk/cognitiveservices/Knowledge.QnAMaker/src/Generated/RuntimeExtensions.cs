// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Knowledge.QnAMaker
{
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for Runtime.
    /// </summary>
    public static partial class RuntimeExtensions
    {
            /// <summary>
            /// GenerateAnswer call to query the knowledgebase.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='kbId'>
            /// Knowledgebase id.
            /// </param>
            /// <param name='generateAnswerPayload'>
            /// Post body of the request.
            /// </param>
            public static QnASearchResultList GenerateAnswer(this IRuntime operations, string kbId, QueryDTO generateAnswerPayload)
            {
                return operations.GenerateAnswerAsync(kbId, generateAnswerPayload).GetAwaiter().GetResult();
            }

            /// <summary>
            /// GenerateAnswer call to query the knowledgebase.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='kbId'>
            /// Knowledgebase id.
            /// </param>
            /// <param name='generateAnswerPayload'>
            /// Post body of the request.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<QnASearchResultList> GenerateAnswerAsync(this IRuntime operations, string kbId, QueryDTO generateAnswerPayload, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GenerateAnswerWithHttpMessagesAsync(kbId, generateAnswerPayload, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Train call to add suggestions to the knowledgebase.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='kbId'>
            /// Knowledgebase id.
            /// </param>
            /// <param name='trainPayload'>
            /// Post body of the request.
            /// </param>
            public static void Train(this IRuntime operations, string kbId, FeedbackRecordsDTO trainPayload)
            {
                operations.TrainAsync(kbId, trainPayload).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Train call to add suggestions to the knowledgebase.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='kbId'>
            /// Knowledgebase id.
            /// </param>
            /// <param name='trainPayload'>
            /// Post body of the request.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task TrainAsync(this IRuntime operations, string kbId, FeedbackRecordsDTO trainPayload, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.TrainWithHttpMessagesAsync(kbId, trainPayload, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

    }
}
