// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.


namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;

    /// <summary>
    /// The interface IExcelApplicationRequest.
    /// </summary>
    public partial interface IExcelApplicationRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified ExcelApplication using PUT.
        /// </summary>
        /// <param name="excelApplicationToCreate">The ExcelApplication to create.</param>
        /// <returns>The created ExcelApplication.</returns>
        System.Threading.Tasks.Task<ExcelApplication> CreateAsync(ExcelApplication excelApplicationToCreate);        /// <summary>
        /// Creates the specified ExcelApplication using PUT.
        /// </summary>
        /// <param name="excelApplicationToCreate">The ExcelApplication to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created ExcelApplication.</returns>
        System.Threading.Tasks.Task<ExcelApplication> CreateAsync(ExcelApplication excelApplicationToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified ExcelApplication.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified ExcelApplication.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified ExcelApplication.
        /// </summary>
        /// <returns>The ExcelApplication.</returns>
        System.Threading.Tasks.Task<ExcelApplication> GetAsync();

        /// <summary>
        /// Gets the specified ExcelApplication.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The ExcelApplication.</returns>
        System.Threading.Tasks.Task<ExcelApplication> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified ExcelApplication using PATCH.
        /// </summary>
        /// <param name="excelApplicationToUpdate">The ExcelApplication to update.</param>
        /// <returns>The updated ExcelApplication.</returns>
        System.Threading.Tasks.Task<ExcelApplication> UpdateAsync(ExcelApplication excelApplicationToUpdate);

        /// <summary>
        /// Updates the specified ExcelApplication using PATCH.
        /// </summary>
        /// <param name="excelApplicationToUpdate">The ExcelApplication to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated ExcelApplication.</returns>
        System.Threading.Tasks.Task<ExcelApplication> UpdateAsync(ExcelApplication excelApplicationToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IExcelApplicationRequest Expand(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IExcelApplicationRequest Select(string value);

    }
}