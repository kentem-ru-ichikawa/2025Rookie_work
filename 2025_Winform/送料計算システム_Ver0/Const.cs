namespace 送料計算システム_First
{
    public enum PackageSize
    {
        NONE,
        S,
        M,
        L,
    }

    public static class Const
    {
        // 各サイズの送料
        public const int SIZE_NONE_PRICE = -1;
        public const int SIZE_S_PRICE = 600;
        public const int SIZE_M_PRICE = 1200;
        public const int SIZE_L_PRICE = 1800;

        // 3辺の合計（各数値以下）
        public const double SIZE_S_THREE_SIDES_LIMIT = 60;
        public const double SIZE_M_THREE_SIDES_LIMIT = 120;
        public const double SIZE_L_THREE_SIDES_LIMIT = 180;

        public const double SIZE_MIN = 0.1;
        public const double SIZE_MAX = 180;

        // 重量（各数値以下）
        public const double SIZE_S_WEIGHT_LIMIT = 10;
        public const double SIZE_M_WEIGHT_LIMIT = 20;
        public const double SIZE_L_WEIGHT_LIMIT = 30;

        public const double WEIGHT_MIN = 0.1;
        public const double WEIGHT_MAX = 50;

        // エラーメッセージ
        public const string ERROR_MESSAGE_INVALID = "入力値が不正です。";
        public const string ERROR_MESSAGE_INVALID_SIZE = "入力値が範囲外です。";
        public const string ERROR_MESSAGE_INVALID_CALC = "サイズ判定できません。";
    }
}
