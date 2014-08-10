using System;
using System.Linq;
using TennoLink.Utils;

namespace TennoLink.Models.Enums
{
    public enum Faction
    {
        [Identifier("FC_CORPUS")]
        Corpus,
        [Identifier("FC_GRINEER")]
        Grineer,
        [Identifier("FC_INFESTATION")]
        Infested
    }
}