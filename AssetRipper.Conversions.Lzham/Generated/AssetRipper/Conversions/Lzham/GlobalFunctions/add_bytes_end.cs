using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?add_bytes_end@search_accelerator@lzham@@QEAAXXZ")]
[DemangledName("public: void __cdecl lzham::search_accelerator::add_bytes_end(void)")]
internal static partial class add_bytes_end
{
	[return: NativeType("void")]
	public unsafe static void Invoke(void* @this)
	{
		unchecked
		{
			if (((lzham_search_accelerator*)@this)->m_pTask_pool != null)
			{
				join.Invoke(((lzham_search_accelerator*)@this)->m_pTask_pool);
			}
		}
	}
}
