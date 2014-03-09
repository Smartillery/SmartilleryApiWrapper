using System;
using System.Collections.Generic;

namespace SmartilleryUnityWrapper
{
    public interface ISmartilleryApi
    {
		/// <summary>
		/// Login to smartillery using the specified username and password.
		/// </summary>
		/// <param name="username">the username</param>
		/// <param name="password">the password</param>
		/// <exception cref="InvalidUserPassException">Username or password was invalid</exception>
		/// <exception cref="ConnectionTimeoutException">Connection to server could not be estabilshed</exception>
		void Login(string username, string password);

		/// <summary>
		/// Updates the location of the player.
		/// </summary>
		/// <param name="latitude">Latitude.</param>
		/// <param name="longitude">Longitude.</param>
		/// <exception cref="ConnectionTimeoutException">Connection to server could not be estabilshed</exception>
		void UpdateLocation(Location location);

		/// <summary>
		/// Gets information about the currently logged in player
		/// </summary>
		/// <returns>The current player.</returns>
		/// <exception cref="ConnectionTimeoutException">Connection to server could not be estabilshed</exception>
		Player GetCurrentPlayer();

		/// <summary>
		/// Gets all enemy players
		/// </summary>
		/// <returns>The enemy players.</returns>
		/// <exception cref="ConnectionTimeoutException">Connection to server could not be estabilshed</exception>
		ICollection<Player> GetEnemyPlayers();

		/// <summary>
		/// Gets all launches
		/// </summary>
		/// <returns>The launches.</returns>
		/// <exception cref="ConnectionTimeoutException">Connection to server could not be estabilshed</exception>
		ICollection<Launch> GetLaunches();

		/// <summary>
		/// Gets all launches that have been created since a particular time
		/// </summary>
		/// <returns>The launches</returns>
		/// <param name="since">get all lauches since this time</param>
		/// <exception cref="ConnectionTimeoutException">Connection to server could not be estabilshed</exception>
		ICollection<Launch> GetLaunches(DateTime since);
    }
}

