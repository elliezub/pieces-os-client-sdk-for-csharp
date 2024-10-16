namespace Pieces.OS.Client.Copilot;

using Pieces.Os.Core.SdkModel;

public interface IPiecesCopilot
{
    /// <summary>
    /// The AI model to use for all newly generated chats. Changing this will not affect existing chats
    /// </summary>
    Model Model { get; set; }

    /// <summary>
    /// Create a new chat with the copilot
    /// </summary>
    /// <param name="chatName">An optional name for the chat. If nothing is provided, the name will be New conversation</param>
    /// <param name="chatContext">An optional list of asset Ids to add to the chat</param>
    /// <param name="model">The LLM model to use</param>
    /// <param name="cancellationToken">A cancellation token</param>
    /// <returns>The new chat</returns>
    Task<ICopilotChat> CreateChatAsync(string chatName = "", ChatContext? chatContext = null, Model? model = default, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get all the chats with the current copilot
    /// </summary>
    IEnumerable<ICopilotChat> Chats { get; }

    /// <summary>
    /// Deletes a copilot chat
    /// </summary>
    /// <param name="chat">The chat to delete</param>
    /// <returns></returns>
    Task DeleteChatAsync(ICopilotChat chat, CancellationToken cancellationToken = default);
}
