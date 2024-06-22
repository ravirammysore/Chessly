using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace Chessly.Puzzles;

public class Puzzle : Entity<Guid>
{
    public string ShortDescription { get; set; } = string.Empty;
    public string LongDescription { get; set; } = string.Empty;
    public string FEN { get; set; } = string.Empty;
    public int MaxMoves { get; set; }
    public PuzzleType Type { get; set; }
}
