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
		/// Launch
		/// </summary>
		/// <param name="angle">the angle of firing in degrees, between 0 and 89</param> 
		/// <param name="bearing">the direction of the launch in degrees, 0 is N, 90 is E</param> 
		/// <exception cref="ConnectionTimeoutException">Connection to server could not be established</exception>
		/// <returns>>Launch back from server fully populated</returns>
		Launch Launch(double angle, double bearing);

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

