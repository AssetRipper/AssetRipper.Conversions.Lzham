namespace AssetRipper.Conversions.Lzham.GlobalVariables;

internal static partial class g_exit_on_failure
{
	private static sbyte __value;

	public static sbyte Value
	{
		get
		{
			return __value;
		}
		set
		{
			__value = value;
		}
	}

	static g_exit_on_failure()
	{
		Value = 1;
	}
}
