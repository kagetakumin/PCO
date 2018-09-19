using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DefineConstant
{
    public enum CardType
    {
        Pokemon,
        Trainers,
        Support,
    }

    public enum PokemonStage
    {
        Basic,
        Stage1,
        Stage2
    }

    public enum PokemonType
    {
        None,
        Fire,
        Water,
        Lightning,
        Grass,
        Fighting,
        Darkness,
        Metal,
        Fairy,
    }

    public enum SpecialType
    {
        None,
        GX,
        Prism,

        Limited,
        NoneLimited,
    }

    public enum InputState
    {
        None,
        Trigger,
        Stay,
        Release,
    }
}
