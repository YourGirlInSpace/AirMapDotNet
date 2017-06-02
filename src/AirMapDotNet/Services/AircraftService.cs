using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using AirMapDotNet.Entities;
using AirMapDotNet.Entities.AircraftAPI;

namespace AirMapDotNet.Services
{
    /// <summary>
    /// Exposes several methods for the Aircraft API.
    /// </summary>
    internal class AircraftService : AirMapService
    {
        internal AircraftService(AirMap am)
            : base(am)
        { }


        /// <summary>
        /// Retrieves the list of recognized manufacturers.
        /// </summary>
        /// <returns>A list of recognized manufacturers.</returns>
        /// <exception cref="AirMapException">If the request fails.</exception>
        // Properties with HTTP requests are bad, mmkay?
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate")]
        public async Task<IEnumerable<Manufacturer>> GetManufacturers()
        {
            Href<EntityCollection<Manufacturer>> manufacturerLink =
                new Href<EntityCollection<Manufacturer>>(new Uri(AirMap_Aircraft_Manufacturers));

            EntityCollection<Manufacturer> manuCollection = await AirMap.GetAsync(manufacturerLink);

            return manuCollection;
        }

        /// <summary>
        /// Retrieves a list of drone models.
        /// </summary>
        /// <param name="manufacturerID">Optional manufacturer GUID.</param>
        /// <param name="modelFilter">Optional model filter.</param>
        /// <returns>A list of drone models filtered by <paramref name="manufacturerID"/> and <paramref name="modelFilter"/>.</returns>
        /// <remarks>The filters both expect full phrases, such as "Phantom" for the Phantom 3.</remarks>
        /// <example>
        /// <code>
        /// AirMap am = new AirMap("YOUR API KEY");
        /// 
        /// // All Phantom drones from DJI
        /// var phantoms = await am.GetModels(manufacturerID: "2a55b47e-ca49-4b7e-99c7-dee9cd784ec9", modelFilter: "phantom");
        /// 
        /// // All drones by Yuneec
        /// var phantoms = await am.GetModels(manufacturerID: "0c71de37-d500-4702-91ef-56d7ec606aa7");
        /// 
        /// // All drones containing the word "Typhoon"
        /// var phantoms = await am.GetModels(modelFilter: "Typhoon");
        /// </code></example>
        /// <exception cref="AirMapException">If the request fails.</exception>
        /// <exception cref="ArgumentNullException">If both <paramref name="modelFilter"/> and <paramref name="manufacturerID"/> are null or equals <see cref="string.Empty"/>.</exception>
        public async Task<IEnumerable<Model>> GetModels(string manufacturerID, string modelFilter)
        {
            if (string.IsNullOrEmpty(manufacturerID) && string.IsNullOrEmpty(modelFilter))
                throw new ArgumentNullException(nameof(manufacturerID), "Must have at least one parameter declared.");

            Href<EntityCollection<Model>> modelLink =
                new Href<EntityCollection<Model>>(new Uri(AirMap_Aircraft_Models));

            NameValueCollection query = new NameValueCollection();

            if (!string.IsNullOrWhiteSpace(manufacturerID))
                query.Add("manufacturer", manufacturerID);
            if (!string.IsNullOrWhiteSpace(modelFilter))
                query.Add("q", modelFilter);

            EntityCollection<Model> modelCollection = await AirMap.GetAsync(modelLink, query);

            return modelCollection;
        }

        /// <summary>
        /// Retrieves a list of drone models from a particular manufacturer.
        /// </summary>
        /// <param name="manufacturer">The manufacturer of the drone.</param>
        /// <returns>A list of drone models by <paramref name="manufacturer"/>.</returns>
        /// <exception cref="ArgumentNullException">If <paramref name="manufacturer"/> is null.</exception>
        /// <exception cref="AirMapException">If the request fails.</exception>
        /// <example>
        /// <code>
        /// AirMap am = new AirMap("YOUR API KEY");
        /// 
        /// // All Phantom drones from DJI
        /// var phantoms = await am.GetModels(manufacturerID: "2a55b47e-ca49-4b7e-99c7-dee9cd784ec9", modelFilter: "phantom");
        /// 
        /// // All drones by Yuneec
        /// var phantoms = await am.GetModels(manufacturerID: "0c71de37-d500-4702-91ef-56d7ec606aa7");
        /// 
        /// // All drones containing the word "Typhoon"
        /// var phantoms = await am.GetModels(modelFilter: "Typhoon");
        /// </code></example>
        public async Task<IEnumerable<Model>> GetModels(Manufacturer manufacturer)
        {
            if (manufacturer == null)
                throw new ArgumentNullException(nameof(manufacturer));

            Href<EntityCollection<Model>> modelLink =
                new Href<EntityCollection<Model>>(new Uri(AirMap_Aircraft_Models));

            NameValueCollection query = new NameValueCollection
            {
                ["manufacturer"] = manufacturer.ID
            };

            EntityCollection<Model> modelCollection = await AirMap.GetAsync(modelLink, query);

            return modelCollection;
        }

        /// <summary>
        /// Retrieves a drone model using its unique GUID.
        /// </summary>
        /// <param name="modelId">The drone model's GUID.</param>
        /// <returns>A <see cref="Model"/> containing the drone model's information.</returns>
        /// <example>
        /// <code>
        /// AirMap am = new AirMap("YOUR API KEY");
        /// 
        /// // Information on the Phantom 3
        /// var phantom3 = await am.GetModel("b3b1c26f-06da-4eae-9390-667c90039175");
        /// </code></example>
        /// <exception cref="AirMapException">If the request fails.</exception>
        /// <exception cref="ArgumentNullException">If <paramref name="modelId"/> is null or equals <see cref="string.Empty"/>.</exception>
        public async Task<Model> GetModel(string modelId)
        {
            if (string.IsNullOrEmpty(modelId))
                throw new ArgumentNullException(nameof(modelId));

            Href<Model> modelLink = new Href<Model>(new Uri(string.Format(AirMap_Aircraft_Model, modelId)));

            return await AirMap.GetAsync(modelLink);
        }
    }
}