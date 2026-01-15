using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?encode_bits@symbol_codec@lzham@@QEAA_NII@Z")]
[DemangledName("public: bool __cdecl lzham::symbol_codec::encode_bits(unsigned int, unsigned int)")]
internal static partial class encode_bits
{
	[return: NativeType("bool")]
	public unsafe static bool Invoke(void* @this, [NativeType("unsigned int")] int bits, [NativeType("unsigned int")] int num_bits)
	{
		switch (num_bits)
		{
		case 0:
			return true;
		default:
		{
			bool flag2 = record_put_bits.Invoke(@this, bits >>> 16, unchecked(num_bits - 16));
			if (ExceptionInfo.Current != null)
			{
				return false;
			}
			if (!flag2)
			{
				return false;
			}
			bool flag3 = record_put_bits.Invoke(@this, bits & 0xFFFF, 16);
			if (ExceptionInfo.Current != null)
			{
				return false;
			}
			if (!flag3)
			{
				return false;
			}
			break;
		}
		case 1:
		case 2:
		case 3:
		case 4:
		case 5:
		case 6:
		case 7:
		case 8:
		case 9:
		case 10:
		case 11:
		case 12:
		case 13:
		case 14:
		case 15:
		case 16:
		{
			bool flag = record_put_bits.Invoke(@this, bits, num_bits);
			if (ExceptionInfo.Current != null)
			{
				return false;
			}
			if (!flag)
			{
				return false;
			}
			break;
		}
		}
		return true;
	}
}
