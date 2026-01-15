using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Intrinsics.Implemented;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?lzham_default_realloc@lzham@@YAPEAXPEAX_KPEA_KI0@Z")]
[DemangledName("void * __cdecl lzham::lzham_default_realloc(void *, unsigned __int64, unsigned __int64 *, unsigned int, void *)")]
internal static partial class lzham_default_realloc
{
	public unsafe static readonly void* __pointer = PointerIndices.Register((delegate*<void*, long, void*, int, void*, void*>)(&Invoke));

	[return: NativeType("void *")]
	public unsafe static void* Invoke([NativeType("void *")] void* p, [NativeType("unsigned __int64")] long size, [NativeType("unsigned __int64 *")] void* pActual_size, [NativeType("unsigned int")] int movable, [NativeType("void *")] void* pUser_data)
	{
		unchecked
		{
			void* ptr;
			if (p == null)
			{
				ptr = malloc.Invoke(size);
				if (pActual_size != null)
				{
					*(long*)pActual_size = ((ptr == null) ? 0L : msize.Invoke(ptr));
				}
			}
			else if (size == 0L)
			{
				free.Invoke(p);
				ptr = null;
				if (pActual_size != null)
				{
					*(long*)pActual_size = 0L;
				}
			}
			else
			{
				void* ptr2 = p;
				ptr = null;
				if (ptr != null)
				{
					ptr2 = ptr;
				}
				else if (movable != 0)
				{
					ptr = realloc.Invoke(p, size);
					if (ptr != null)
					{
						ptr2 = ptr;
					}
				}
				if (pActual_size != null)
				{
					*(long*)pActual_size = msize.Invoke(ptr2);
				}
			}
			return ptr;
		}
	}
}
