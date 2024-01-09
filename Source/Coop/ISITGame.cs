﻿using EFT;
using StayInTarkov.Networking;
using System.Collections.Generic;

namespace StayInTarkov.Coop
{
    public interface ISITGame
    {
        public List<string> ExtractedPlayers { get; }

        Dictionary<string, (float, long, string)> ExtractingPlayers { get; }

        ExitStatus MyExitStatus { get; set; }

        string MyExitLocation { get; set; }

        public void Stop(string profileId, ExitStatus exitStatus, string exitName, float delay = 0f);

        public IGameClient GameClient { get; }

        //GameStatus Status { get; }
    }
}
