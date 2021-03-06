﻿using System.Threading.Tasks;
using SlackConnector.Models;

namespace Hjerpbakk.Profilebot.Contracts {
    /// <summary>
    ///     Validates the profile of a Slack user according to your team's rules.
    /// </summary>
    public interface ISlackProfileValidator {
        /// <summary>
        ///     Validates that a user profile is complete.
        /// </summary>
        /// <param name="user">The user to be validated.</param>
        /// <returns>The result of the validation.</returns>
        Task<ProfileValidationResult> ValidateProfile(SlackUser user);
    }
}