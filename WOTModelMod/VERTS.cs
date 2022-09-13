using System.IO;

namespace WOTModelMod
{
	internal struct VERTS
	{
		public VT3 vert;

		public VT3 normal;

		public VT3 tan;

		public VT3 bin;

		public VT2 tvert;

		public byte[] wwwii;

		public string wwstr;

		public VERTS(BinaryReader r, bool wwwi)
		{
			vert = new VT3(r);
			normal = default(VT3);
			normal.ReadUIntXYZ(r);
			tvert = new VT2(r);
			if (wwwi)
			{
				wwwii = r.ReadBytes(5);
			}
			else
			{
				wwwii = new byte[0];
			}
			tan = default(VT3);
			tan.ReadUIntXYZ(r);
			bin = default(VT3);
			bin.ReadUIntXYZ(r);
			if (wwwi)
			{
				wwstr = string.Format("{0}{1}{2}{3}{4}", wwwii[0].ToString("X2"), wwwii[1].ToString("X2"), wwwii[2].ToString("X2"), wwwii[3].ToString("X2"), wwwii[4].ToString("X2"));
			}
			else
			{
				wwstr = "0000000000";
			}
		}

		public void Write(BinaryWriter w)
		{
			vert.Write(w);
			normal.WriteUintXYZ(w);
			tvert.Write(w);
			w.Write(wwwii);
			tan.WriteUintXYZ(w);
			bin.WriteUintXYZ(w);
		}

		public void WriteOBJVert(StreamWriter w)
		{
			w.WriteLine("v {0} {1} {2}", vert.x, vert.y, vert.z);
		}

		public void WriteOBJNormal(StreamWriter w)
		{
			w.WriteLine("vn {0} {1} {2}", normal.x, normal.y, normal.z);
		}

		public void WriteOBJTvert(StreamWriter w)
		{
			w.WriteLine("vt {0} {1}", tvert.x, 1f - tvert.y);
		}
	}
}
