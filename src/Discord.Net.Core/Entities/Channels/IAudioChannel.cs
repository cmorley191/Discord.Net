using Discord.Audio;
using System.Threading.Tasks;

namespace Discord
{
    /// <summary>
    ///     Represents a generic audio channel.
    /// </summary>
    public interface IAudioChannel : IChannel
    {
        /// <summary>
        /// The <see cref="IAudioClient"/> responsible for connections to this channel.
        /// </summary>
        IAudioClient AudioClient { get; }

        /// <summary>
        ///     Connects to this audio channel.
        /// </summary>
        /// <param name="selfDeaf">Determines whether the client should deaf itself upon connection.</param>
        /// <param name="selfMute">Determines whether the client should mute itself upon connection.</param>
        /// <param name="external">Determines whether the audio client is an external one or not.</param>
        /// <returns>
        ///     A task representing the asynchronous connection operation.
        /// </returns>
        Task ConnectAsync(bool selfDeaf = false, bool selfMute = false, bool external = false);

        /// <summary>
        ///     Disconnects from this audio channel.
        /// </summary>
        /// <returns>
        ///     A task representing the asynchronous operation for disconnecting from the audio channel.
        /// </returns>
        Task DisconnectAsync();
    }
}
