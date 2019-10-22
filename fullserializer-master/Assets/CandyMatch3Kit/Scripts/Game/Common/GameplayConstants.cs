// Copyright (C) 2017-2019 gamevanilla. All rights reserved.
// This code can only be used under the standard Unity Asset Store End User License Agreement,
// a copy of which is available at http://unity3d.com/company/legal/as_terms.

namespace GameVanilla.Game.Common
{
    public static class GameplayConstants
    {
        // 이 시간 후 하이라이트 힌트
        public const float TimeBetweenRandomMatchSuggestions = 5.0f;

        // 보상 캔디 생성 딜레이
        public const float TimeBetweenRewardedCandiesCreation = 0.5f;

        // 보상 캔디 폭발 딜레이
        public const float TimeBetweenRewardedCandiesExplosion = 0.25f; // 1.0f;

        public const float EndGamePopupDelay = 0.75f;
    }
}
