using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?stop@lzham_timer@lzham@@QEAAXXZ")]
[DemangledName("public: void __cdecl lzham::lzham_timer::stop(void)")]
internal static partial class stop
{
	[return: NativeType("void")]
	public unsafe static void Invoke(void* @this)
	{
		unchecked
		{
			query_counter.Invoke(&((lzham_lzham_timer*)@this)->field_1);
			sbyte* field_ = &((lzham_lzham_timer*)@this)->field_2;
			*field_ = (sbyte)((*field_ & -3) | 2);
		}
	}
}
