﻿using Creek.FileRepository.Models;
using System.Threading.Tasks;

namespace Creek.FileRepository
{
    /// <summary>
    /// A repository interface to ensure that all storage repositories implement all the required methods, and that the methods are all generic.
    /// </summary>
    public interface IFileRepository
    {
        /// <summary>
        /// Create a file in the repository.
        /// </summary>
        /// <param name="file">The file to store.</param>
        /// <returns>Returns a string filename of the created file.</returns>
        Task<string> CreateFileAsync(RepoFile file);

        /// <summary>
        /// Read a file from the repository.
        /// </summary>
        /// <param name="filename">The file name of the file to read.</param>
        /// <returns>Returns the file from the repository.</returns>
        Task<RepoFile> ReadFileAsync(string filename);

        /// <summary>
        /// Update a file in the repository.
        /// </summary>
        /// <param name="file">The file to store.</param>
        /// <returns>Returns a boolean representing whether or not the update was successful.</returns>
        Task<bool> UpdateFileAsync(RepoFile file);

        /// <summary>
        /// Delete a file in the repository.
        /// </summary>
        /// <param name="filename">The file name of the file to delete.</param>
        /// <returns>Returns a boolean representing whether or not the delete was successful.</returns>
        Task<bool> DeleteFileAsync(string filename);
    }
}
