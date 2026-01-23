using AssetRipper.Conversions.Lzham.GlobalVariables;
using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?lzham_lib_z_error@lzham@@YAPEBDH@Z")]
[DemangledName("char const * __cdecl lzham::lzham_lib_z_error(int)")]
internal static partial class lzham_lib_z_error
{
	[return: NativeType("char const *")]
	public unsafe static void* Invoke([NativeType("int")] int err)
	{
		unchecked
		{
			for (int i = 0; (ulong)(uint)i < 10uL; i++)
			{
				if (((anon*)s_error_descs.Pointer)[(uint)i].m_err == err)
				{
					return ((anon*)s_error_descs.Pointer)[(uint)i].m_pDesc;
				}
			}
			return null;
		}
	}
}
