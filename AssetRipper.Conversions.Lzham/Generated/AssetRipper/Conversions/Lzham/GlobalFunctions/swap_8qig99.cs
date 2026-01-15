using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("??$swap@I$0A@@std@@YAXAEAI0@Z")]
[DemangledName("void __cdecl std::swap<unsigned int, 0>(unsigned int &, unsigned int &)")]
[CleanName("swap")]
internal static partial class swap_8qig99
{
	[return: NativeType("void")]
	public unsafe static void Invoke([MangledName("_Left")][NativeType("unsigned int &")] void* Left, [MangledName("_Right")][NativeType("unsigned int &")] void* Right)
	{
		unchecked
		{
			int num = *(int*)Left;
			*(int*)Left = *(int*)Right;
			*(int*)Right = num;
		}
	}
}
