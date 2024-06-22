using Chessly.Puzzles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace Chessly;

public class ChesslyDataSeederContributor
    : IDataSeedContributor, ITransientDependency
{
    private readonly IRepository<Puzzle, Guid> _PuzzleRepository;

    public ChesslyDataSeederContributor(IRepository<Puzzle, Guid> PuzzleRepository)
    {
        _PuzzleRepository = PuzzleRepository;
    }

    public async Task SeedAsync(DataSeedContext context)
    {
        if (await _PuzzleRepository.GetCountAsync() <= 0)
        {
            await _PuzzleRepository.InsertAsync(
                new Puzzle
                {
                    ShortDescription = "Mate in 1",
                    LongDescription = "Find the checkmate move in one move for white. This puzzle helps beginners to spot immediate checkmates.",
                    FEN = "8/8/8/8/8/5k2/6Q1/7K w - - 0 1",
                    MaxMoves = 1,
                    Type = PuzzleType.Checkmate
                },
                autoSave: true
            );

            await _PuzzleRepository.InsertAsync(
                new Puzzle
                {
                    ShortDescription = "Fork Strategy",
                    LongDescription = "Identify the move that forks the opponent's pieces. This puzzle improves your strategic thinking.",
                    FEN = "8/8/8/3N4/8/5k2/6R1/7K w - - 0 1",
                    MaxMoves = 3,
                    Type = PuzzleType.Strategy
                },
                autoSave: true
            );
        }
    }
}
