using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?start@lzham_timer@lzham@@QEAAXXZ")]
[DemangledName("public: void __cdecl lzham::lzham_timer::start(void)")]
[CleanName("start")]
internal static partial class start_qr7y7s
{
	[return: NativeType("void")]
	public unsafe static void Invoke(void* @this)
	{
		unchecked
		{
			query_counter.Invoke(&((lzham_lzham_timer*)@this)->field_0);
			sbyte* field_ = &((lzham_lzham_timer*)@this)->field_2;
			*field_ = (sbyte)((*field_ & -2) | 1);
			sbyte* field_2 = &((lzham_lzham_timer*)@this)->field_2;
			*field_2 = (sbyte)((*field_2 & -3) | 0);
		}
	}
}
