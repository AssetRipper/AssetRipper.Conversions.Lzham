using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?decode_remove_bits@symbol_codec@lzham@@QEAAXI@Z")]
[DemangledName("public: void __cdecl lzham::symbol_codec::decode_remove_bits(unsigned int)")]
internal static partial class decode_remove_bits
{
	[return: NativeType("void")]
	public unsafe static void Invoke(void* @this, [NativeType("unsigned int")] int num_bits)
	{
		int num = num_bits;
		unchecked
		{
			while ((uint)num > 16u)
			{
				remove_bits.Invoke(@this, 16);
				if (ExceptionInfo.Current != null)
				{
					return;
				}
				num -= 16;
			}
			remove_bits.Invoke(@this, num);
		}
	}
}
