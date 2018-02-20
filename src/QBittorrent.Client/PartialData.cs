﻿using System.Collections.Generic;
using Newtonsoft.Json;

namespace QBittorrent.Client
{
    /// <summary>
    /// Represents full or partial data returned by <see cref="QBittorrentClient.GetPartialDataAsync"/> method.
    /// </summary>
    public class PartialData
    {
        /// <summary>
        /// Gets or sets the response identifier.
        /// </summary>
        /// <value>
        /// The response identifier.
        /// </value>
        [JsonProperty("rid")]
        public int ResponseId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this object contains all data.
        /// </summary>
        /// <value>
        ///   <see langword="true" /> if this object contains all data; 
        ///   <see langword="false" /> if this object contains only changes of data since the previous request.
        /// </value>
        [JsonProperty("full_update")]
        public bool FullUpdate { get; set; }

        /// <summary>
        /// Gets or sets the list of changed or added torrents.
        /// </summary>
        [JsonProperty("torrents")]
        public IReadOnlyDictionary<string, TorrentPartialInfo> TorrentsChanged { get; set; }

        /// <summary>
        /// Gets or sets the list of removed torrents.
        /// </summary>
        [JsonProperty("torrents_removed")]
        public IReadOnlyList<string> TorrentsRemoved { get; set; }

        /// <summary>
        /// Gets or sets the list of added categories.
        /// </summary>
        [JsonProperty("categories")]
        public IReadOnlyList<string> CategoriesAdded { get; set; }

        /// <summary>
        /// Gets or sets the list of removed categories.
        /// </summary>
        [JsonProperty("categories_removed")]
        public IReadOnlyList<string> CategoriesRemoved { get; set; }

        /// <summary>
        /// Priority system usage flag
        /// </summary>
        [JsonProperty("queueing")]
        public bool Queueing { get; set; }

        /// <summary>
        /// Gets or sets the state of the server.
        /// </summary>
        [JsonProperty("server_state")]
        public GlobalTransferInfo ServerState { get; set; }
    }
}
