using System;
using System.Collections.Generic;
using Vanessa.Models;

namespace Vanessa.Services {
    public static class EventService {
        public class RankItem {
            public User user;
            public ulong rank;
            public ulong score;
        }
        public static List<RankItem> GetRanks () {
            throw new NotImplementedException ();
        }
    }
}