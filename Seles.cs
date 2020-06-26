namespace TugasPolyDanCol
{
    class Sales : Karyawan
    {
        public double Komisi;

        public double JumlahPenjualan;

        public override double Gaji()
        {
            return (Komisi * JumlahPenjualan);
        }
    }
}