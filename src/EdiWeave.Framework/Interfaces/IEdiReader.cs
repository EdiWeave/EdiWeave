using System.Collections.Generic;
using EdiWeave.Core.Model.Edi;

namespace EdiWeave.Framework.Readers
{
  public interface IEdiReader
  {
    /// <summary>
    /// EDI separators.
    /// </summary>
    Separators Separators { get; }

    /// <summary>
    /// The last item that was read.
    /// </summary>
    EdiItem Item { get; }

    /// <summary>
    /// Indicates whether the current stream position is at the end of the stream.
    /// </summary>
    bool EndOfStream { get; }

    /// <summary>
    /// Reads an item from the stream.
    /// </summary>
    /// <returns>Indication if an item was read.</returns>
    bool Read();

    /// <summary>
    /// Reads the stream to the end.
    /// </summary>
    /// <returns>All items that were found in the stream.</returns>
    IEnumerable<EdiItem> ReadToEnd();

    /// <summary>
    /// Disposes the reader.
    /// </summary>
    void Dispose();
  }
}