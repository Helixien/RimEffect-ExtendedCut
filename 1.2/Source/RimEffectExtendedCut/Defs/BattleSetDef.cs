﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Verse;

namespace RimEffectExtendedCut
{
	public enum BattleCondition
    {
		None,
		Win,
		Lose,
		Draw
    }
	public class BattleSet
    {
		public BattleSetStep startingTexture;
		public List<BattleSetStep> playingTextures;
		public List<BattleSetStep> winningTextures;
	}
	public class BattleSetStep
    {
		public IntRange ticksInterval;
		public string texPath;
		public BattleCondition playerA;
		public BattleCondition playerB;
	}
	public class BattleSetDef : Def
	{
		public GraphicData battleSetGraphicData;
		public BattleSet battleSetTextures;
	}
}