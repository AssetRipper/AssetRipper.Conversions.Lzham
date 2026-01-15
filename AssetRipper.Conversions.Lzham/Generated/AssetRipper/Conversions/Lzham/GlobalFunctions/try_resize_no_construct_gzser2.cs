using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?try_resize_no_construct@?$vector@Udict_match@lzham@@@lzham@@QEAA_NI_N@Z")]
[DemangledName("public: bool __cdecl lzham::vector<struct lzham::dict_match>::try_resize_no_construct(unsigned int, bool)")]
[CleanName("try_resize_no_construct")]
internal static partial class try_resize_no_construct_gzser2
{
	[return: NativeType("bool")]
	public unsafe static bool Invoke(void* @this, [NativeType("unsigned int")] int new_size, [NativeType("bool")] bool grow_hint)
	{
		sbyte b = (grow_hint ? ((sbyte)1) : ((sbyte)0));
		unchecked
		{
			if ((uint)new_size > (uint)((lzham_vector*)@this)->m_capacity)
			{
				bool flag = increase_capacity_wegvee.Invoke(@this, new_size, (new_size != ((lzham_vector*)@this)->m_size + 1) ? ((b & 1) == 1) : true, nofail: true);
				if (ExceptionInfo.Current != null)
				{
					return false;
				}
				if (!flag)
				{
					return false;
				}
			}
			((lzham_vector*)@this)->m_size = new_size;
			return true;
		}
	}
}
