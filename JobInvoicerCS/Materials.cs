using System.Windows.Forms;

namespace JobInvoicerCS
{
    public class Materials
    {
        public static double LbsPerSqFtSize(string material)
        {
            var mat = material.ToUpper();
            switch (mat)
            {
                case "L":
                    return AngleMaterial(mat);
                case "CHKD":
                    return CheckedPlateMaterial(mat);
                case "FL":
                    return FlatPlateMaterial(mat);
                case "PL":
                    return PlateMaterial(mat);
                case "RB":
                    return RoundbarMaterial(mat);
                case "TS":
                    return TubeSteelMaterial(mat);
                default:
                    MessageBox.Show(@"The Material size not found", material, MessageBoxButtons.OK,
                                    MessageBoxIcon.Stop);
                    return 0;
            }
        }

        private static double AngleMaterial(string material)
        {
            switch (material)
            {
                case "L8x8x1 1/8":
                    return 56.9D;
                case "L8x8x1":
                    return 51.0D;
                case "L8x8x7/8":
                    return 45.0D;
                case "L8x8x3/4":
                    return 38.9D;
                case "L8x8x5/8":
                    return 32.7D;
                case "L8x8x9/16":
                    return 29.6D;
                case "L8x8x1/2":
                    return 26.4D;
                case "L8x6x1":
                    return 44.2D;
                case "L8x6x7/8":
                    return 39.1D;
                case "L8x6x3/4":
                    return 33.8D;
                case "L8x6x5/8":
                    return 28.5D;
                case "L8x6x9/16":
                    return 25.7D;
                case "L8x6x1/2":
                    return 23.0D;
                case "L8x6x7/16":
                    return 20.2D;
                case "L8x4x1":
                    return 37.4D;
                case "L8x4x7/8":
                    return 33.1D;
                case "L8x4x3/4":
                    return 28.7D;
                case "L8x4x5/8":
                    return 24.2D;
                case "L8x4x9/16":
                    return 21.9D;
                case "L8x4x1/2":
                    return 19.6D;
                case "L8x4x7/16":
                    return 17.2D;
                case "L7x4x3/4":
                    return 26.2D;
                case "L7x4x5/8":
                    return 22.1D;
                case "L7x4x1/2":
                    return 17.9D;
                case "L7x4x7/16":
                    return 15.7D;
                case "L7x4x3/8":
                    return 13.6D;
                case "L6x6x1":
                    return 37.4D;
                case "L6x6x7/8":
                    return 33.1D;
                case "L6x6x3/4":
                    return 28.7D;
                case "L6x6x5/8":
                    return 24.2D;
                case "L6x6x9/16":
                    return 21.9D;
                case "L6x6x1/2":
                    return 19.6D;
                case "L6x6x7/16":
                    return 17.2D;
                case "L6x6x3/8":
                    return 14.9D;
                case "L6x6x5/16":
                    return 12.4D;
                case "L6x4x7/8":
                    return 27.2D;
                case "L6x4x3/4":
                    return 23.6D;
                case "L6x4x5/8":
                    return 20.0D;
                case "L6x4x9/16":
                    return 18.1D;
                case "L6x4x1/2":
                    return 16.2D;
                case "L6x4x7/16":
                    return 14.3D;
                case "L6x4x3/8":
                    return 12.3D;
                case "L6x4x5/16":
                    return 10.3D;
                case "L6x3 1/2x1/2":
                    return 15.3D;
                case "L6x3 1/2x3/8":
                    return 11.7D;
                case "L6x3 1/2x5/16":
                    return 9.8D;
                case "L5x5x7/8":
                    return 27.2D;
                case "L5x5x3/4":
                    return 23.6D;
                case "L5x5x5/8":
                    return 20.0D;
                case "L5x5x1/2":
                    return 16.2D;
                case "L5x5x7/16":
                    return 14.3D;
                case "L5x5x3/8":
                    return 12.3D;
                case "L5x5x5/16":
                    return 10.3D;
                case "L5x3 1/2x3/4":
                    return 19.8D;
                case "L5x3 1/2x5/8":
                    return 16.8D;
                case "L5x3 1/2x1/2":
                    return 13.6D;
                case "L5x3 1/2x3/8":
                    return 10.4D;
                case "L5x3 1/2x5/16":
                    return 8.7D;
                case "L5x3 1/2x1/4":
                    return 7.0D;
                case "L5x3x1/2":
                    return 12.8D;
                case "L5x3x7/16":
                    return 11.3D;
                case "L5x3x3/8":
                    return 9.8D;
                case "L5x3x5/16":
                    return 8.2D;
                case "L5x3x1/4":
                    return 6.6D;
                case "L4x4x3/4":
                    return 18.5D;
                case "L4x4x5/8":
                    return 15.7D;
                case "L4x4x1/2":
                    return 12.8D;
                case "L4x4x7/16":
                    return 11.3D;
                case "L4x4x3/8":
                    return 9.8D;
                case "L4x4x5/16":
                    return 8.2D;
                case "L4x4x1/4":
                    return 6.6D;
                case "L4x3 1/2x1/2":
                    return 11.9D;
                case "L4x3 1/2x3/8":
                    return 9.1D;
                case "L4x3 1/2x5/16":
                    return 7.7D;
                case "L4x3 1/2x1/4":
                    return 6.2D;
                case "L4x3x5/8":
                    return 13.6D;
                case "L4x3x1/2":
                    return 11.1D;
                case "L4x3x3/8":
                    return 8.5D;
                case "L4x3x5/16":
                    return 7.2D;
                case "L4x3x1/4":
                    return 5.8D;
                case "L3 1/2x3 1/2x1/2":
                    return 11.1D;
                case "L3 1/2x3 1/2x7/16":
                    return 9.8D;
                case "L3 1/2x3 1/2x3/8":
                    return 8.5D;
                case "L3 1/2x3 1/2x5/16":
                    return 7.2D;
                case "L3 1/2x3 1/2x1/4":
                    return 5.8D;
                case "L3 1/2x3x1/2":
                    return 10.2D;
                case "L3 1/2x3x7/16":
                    return 9.1D;
                case "L3 1/2x3x3/8":
                    return 7.9D;
                case "L3 1/2x3x5/16":
                    return 6.6D;
                case "L3 1/2x3x1/4":
                    return 5.4D;
                case "L3 1/2x2 1/2x1/2":
                    return 9.4D;
                case "L3 1/2x2 1/2x3/8":
                    return 7.2D;
                case "L3 1/2x2 1/2x5/16":
                    return 6.1D;
                case "L3 1/2x2 1/2x1/4":
                    return 4.9D;
                case "L3x3x1/2":
                    return 9.4D;
                case "L3x3x7/16":
                    return 8.3D;
                case "L3x3x3/8":
                    return 7.2D;
                case "L3x3x5/16":
                    return 6.1D;
                case "L3x3x1/4":
                    return 4.9D;
                case "L3x3x3/16":
                    return 3.71D;
                case "L3x2 1/2x1/2":
                    return 8.5D;
                case "L3x2 1/2x7/16":
                    return 7.6D;
                case "L3x2 1/2x3/8":
                    return 6.6D;
                case "L3x2 1/2x5/16":
                    return 5.6D;
                case "L3x2 1/2x1/4":
                    return 4.5D;
                case "L3x2 1/2x3/16":
                    return 3.39D;
                case "L3x2x1/2":
                    return 7.7D;
                case "L3x2x3/8":
                    return 5.9D;
                case "L3x2x5/16":
                    return 5.0D;
                case "L3x2x1/4":
                    return 4.1D;
                case "L3x2x3/16":
                    return 3.07D;
                case "L2 1/2x2 1/2x1/2":
                    return 7.7D;
                case "L2 1/2x2 1/2x3/8":
                    return 5.9D;
                case "L2 1/2x2 1/2x5/16":
                    return 5.0D;
                case "L2 1/2x2 1/2x1/4":
                    return 4.1D;
                case "L2 1/2x2 1/2x3/16":
                    return 3.07D;
                case "L2 1/2x2x3/8":
                    return 5.3D;
                case "L2 1/2x2x5/16":
                    return 4.5D;
                case "L2 1/2x2x1/4":
                    return 3.62D;
                case "L2 1/2x2x3/16":
                    return 2.75D;
                case "L2 1/2x1 1/2x5/16":
                    return 3.92D;
                case "L2 1/2x1 1/2x1/4":
                    return 3.19D;
                case "L2 1/2x1 1/2x3/16":
                    return 2.44D;
                case "L2x2x1/2":
                    return 6.0D;
                case "L2x2x3/8":
                    return 4.7D;
                case "L2x2x5/16":
                    return 3.92D;
                case "L2x2x1/4":
                    return 3.19D;
                case "L2x2x3/16":
                    return 2.44D;
                case "L2x2x1/8":
                    return 1.65D;
                case "L2x1 1/2x1/4":
                    return 2.77D;
                case "L2x1 1/2x3/16":
                    return 2.12D;
                case "L2x1 1/2x1/8":
                    return 1.44D;
                case "L2x1 1/4x3/16":
                    return 1.96D;
                case "L1 3/4x1 3/4x1/4":
                    return 2.77D;
                case "L1 3/4x1 3/4x3/16":
                    return 2.12D;
                case "L1 3/4x1 3/4x1/8":
                    return 1.44D;
                case "L1 1/2x1 1/2x3/8":
                    return 3.35D;
                case "L1 1/2x1 1/2x5/16":
                    return 2.86D;
                case "L1 1/2x1 1/2x1/4":
                    return 2.34D;
                case "L1 1/2x1 1/2x3/16":
                    return 1.8D;
                case "L1 1/2x1 1/2x5/32":
                    return 1.52D;
                case "L1 1/2x1 1/2x1/8":
                    return 1.23D;
                case "L1 1/4x1 1/4x1/4":
                    return 1.92D;
                case "L1 1/4x1 1/4x3/16":
                    return 1.48D;
                case "L1 1/4x1 1/4x1/8":
                    return 1.01D;
                case "L1 1/8x1 1/8x1/8":
                    return 0.91D;
                case "L1x1x1/4":
                    return 1.49D;
                case "L1x1x3/16":
                    return 1.16D;
                case "L1x1x1/8":
                    return 0.8D;
                case "L1x5/8x1/8":
                    return 0.64D;
                case "L7/8x7/8x1/8":
                    return 0.7D;
                case "L3/4x3/4x1/8":
                    return 0.59D;
                case "L5/8x5/8x1/8":
                    return 0.48D;
                case "L1/2x1/2x1/8":
                    return 0.38D;
                default:
                    MessageBox.Show(@"The Material size not found", material, MessageBoxButtons.OK,
                                    MessageBoxIcon.Stop);
                    return 0;
            }
        }

        private static double CheckedPlateMaterial(string material)
        {
            switch (material)
            {
                case "CHKD3/4":
                    return 31.68D;
                case "CHKD5/8":
                    return 26.58D;
                case "CHKD1/2":
                    return 21.47D;
                case "CHKD3/8":
                    return 16.37D;
                case "CHKD5/16":
                    return 13.81D;
                case "CHKD1/4":
                    return 11.26D;
                case "CHKD3/16":
                    return 8.71D;
                case "CHKD1/8":
                    return 6.15D;
                default:
                    MessageBox.Show(@"The Material size not found", material, MessageBoxButtons.OK,
                                    MessageBoxIcon.Stop);
                    return 0;
            }
        }

        private static double FlatPlateMaterial(string material)
        {
            switch (material)
            {
                case "FL1/8x3/4":
                    return 0.32D;
                case "FL1/8x2":
                    return 0.852D;
                case "FL1/8x4":
                    return 1.704D;
                case "FL1/8x8":
                    return 3.408D;
                case "FL1/8x12":
                    return 5.112D;
                case "FL3/16x3/4":
                    return 0.479D;
                case "FL3/16x2":
                    return 1.278D;
                case "FL3/16x4":
                    return 2.556D;
                case "FL3/16x8":
                    return 5.112D;
                case "FL3/16x12":
                    return 7.668D;
                case "FL1/4x3/8":
                    return 0.319D;
                case "FL1/4x1/2":
                    return 0.425D;
                case "FL1/4x5/8":
                    return 0.531D;
                case "FL1/4x3/4":
                    return 0.638D;
                case "FL1/4x7/8":
                    return 0.744D;
                case "FL1/4x1":
                    return 0.85D;
                case "FL1/4x1 1/8":
                    return 0.956D;
                case "FL1/4x1 1/4":
                    return 1.06D;
                case "FL1/4x1 3/8":
                    return 1.17D;
                case "FL1/4x1 1/2":
                    return 1.28D;
                case "FL1/4x1 5/8":
                    return 1.38D;
                case "FL1/4x1 3/4":
                    return 1.49D;
                case "FL1/4x2":
                    return 1.7D;
                case "FL1/4x2 1/4":
                    return 1.91D;
                case "FL1/4x2 1/2":
                    return 2.13D;
                case "FL1/4x2 3/4":
                    return 2.34D;
                case "FL1/4x3":
                    return 2.55D;
                case "FL1/4x3 1/4":
                    return 2.76D;
                case "FL1/4x3 1/2":
                    return 2.98D;
                case "FL1/4x3 3/4":
                    return 3.19D;
                case "FL1/4x4":
                    return 3.4D;
                case "FL1/4x4 1/4":
                    return 3.61D;
                case "FL1/4x4 1/2":
                    return 3.83D;
                case "FL1/4x5":
                    return 4.25D;
                case "FL1/4x5 1/2":
                    return 4.68D;
                case "FL1/4x6":
                    return 5.1D;
                case "FL1/4x7":
                    return 5.95D;
                case "FL1/4x8":
                    return 6.8D;
                case "FL5/16x1/2":
                    return 0.531D;
                case "FL5/16x5/8":
                    return 0.664D;
                case "FL5/16x3/4":
                    return 0.797D;
                case "FL5/16x7/8":
                    return 0.93D;
                case "FL5/16x1":
                    return 1.06D;
                case "FL5/16x1 1/8":
                    return 1.2D;
                case "FL5/16x1 1/4":
                    return 1.33D;
                case "FL5/16x1 3/8":
                    return 1.46D;
                case "FL5/16x1 1/2":
                    return 1.59D;
                case "FL5/16x1 3/4":
                    return 1.86D;
                case "FL5/16x2":
                    return 2.13D;
                case "FL5/16x2 1/4":
                    return 2.39D;
                case "FL5/16x2 1/2":
                    return 2.66D;
                case "FL5/16x2 3/4":
                    return 2.92D;
                case "FL5/16x3":
                    return 3.19D;
                case "FL5/16x3 1/4":
                    return 3.45D;
                case "FL5/16x3 1/2":
                    return 3.72D;
                case "FL5/16x4":
                    return 4.25D;
                case "FL5/16x4 1/2":
                    return 4.78D;
                case "FL5/16x5":
                    return 5.31D;
                case "FL5/16x5 1/2":
                    return 5.84D;
                case "FL5/16x6":
                    return 6.38D;
                case "FL5/16x7":
                    return 7.44D;
                case "FL5/16x8":
                    return 8.5D;
                case "FL3/8x1/2":
                    return 0.638D;
                case "FL3/8x5/8":
                    return 0.797D;
                case "FL3/8x3/4":
                    return 0.956D;
                case "FL3/8x7/8":
                    return 1.12D;
                case "FL3/8x1":
                    return 1.28D;
                case "FL3/8x1 1/8":
                    return 1.43D;
                case "FL3/8x1 1/4":
                    return 1.59D;
                case "FL3/8x1 3/8":
                    return 1.75D;
                case "FL3/8x1 1/2":
                    return 1.91D;
                case "FL3/8x1 5/8":
                    return 2.07D;
                case "FL3/8x1 3/4":
                    return 2.23D;
                case "FL3/8x2":
                    return 2.55D;
                case "FL3/8x2 1/4":
                    return 2.87D;
                case "FL3/8x2 1/2":
                    return 3.19D;
                case "FL3/8x2 3/4":
                    return 3.51D;
                case "FL3/8x3":
                    return 3.83D;
                case "FL3/8x3 1/4":
                    return 4.14D;
                case "FL3/8x3 1/2":
                    return 4.46D;
                case "FL3/8x4":
                    return 5.1D;
                case "FL3/8x4 1/2":
                    return 5.74D;
                case "FL3/8x5":
                    return 6.38D;
                case "FL3/8x5 1/2":
                    return 7.01D;
                case "FL3/8x6":
                    return 7.65D;
                case "FL3/8x7":
                    return 8.93D;
                case "FL3/8x8":
                    return 10.2D;
                case "FL1/2x5/8":
                    return 1.06D;
                case "FL1/2x3/4":
                    return 1.28D;
                case "FL1/2x7/8":
                    return 1.49D;
                case "FL1/2x1":
                    return 1.7D;
                case "FL1/2x1 1/8":
                    return 1.91D;
                case "FL1/2x1 1/4":
                    return 2.13D;
                case "FL1/2x1 3/8":
                    return 2.34D;
                case "FL1/2x1 1/2":
                    return 2.55D;
                case "FL1/2x1 5/8":
                    return 2.76D;
                case "FL1/2x1 3/4":
                    return 2.98D;
                case "FL1/2x2":
                    return 3.4D;
                case "FL1/2x2 1/4":
                    return 3.83D;
                case "FL1/2x2 1/2":
                    return 4.25D;
                case "FL1/2x2 3/4":
                    return 4.68D;
                case "FL1/2x3":
                    return 5.1D;
                case "FL1/2x3 1/4":
                    return 5.53D;
                case "FL1/2x3 1/2":
                    return 5.95D;
                case "FL1/2x3 3/4":
                    return 6.375D;
                case "FL1/2x4":
                    return 6.8D;
                case "FL1/2x4 1/2":
                    return 7.65D;
                case "FL1/2x5":
                    return 8.5D;
                case "FL1/2x5 1/2":
                    return 7.01D;
                case "FL1/2x6":
                    return 10.2D;
                case "FL1/2x7":
                    return 11.9D;
                case "FL1/2x8":
                    return 13.6D;
                case "FL5/8x3/4":
                    return 1.59D;
                case "FL5/8x7/8":
                    return 1.86D;
                case "FL5/8x1":
                    return 2.13D;
                case "FL5/8x1 1/8":
                    return 2.39D;
                case "FL5/8x1 1/4":
                    return 2.66D;
                case "FL5/8x1 3/8":
                    return 2.92D;
                case "FL5/8x1 1/2":
                    return 3.19D;
                case "FL5/8x1 5/8":
                    return 3.45D;
                case "FL5/8x1 3/4":
                    return 3.72D;
                case "FL5/8x2":
                    return 4.25D;
                case "FL5/8x2 1/4":
                    return 4.78D;
                case "FL5/8x2 1/2":
                    return 5.31D;
                case "FL5/8x2 3/4":
                    return 5.84D;
                case "FL5/8x3":
                    return 6.38D;
                case "FL5/8x3 1/4":
                    return 6.91D;
                case "FL5/8x3 1/2":
                    return 7.44D;
                case "FL5/8x4":
                    return 8.5D;
                case "FL5/8x4 1/2":
                    return 9.56D;
                case "FL5/8x5":
                    return 10.63D;
                case "FL5/8x5 1/2":
                    return 11.69D;
                case "FL5/8x6":
                    return 12.75D;
                case "FL5/8x7":
                    return 14.88D;
                case "FL5/8x8":
                    return 17.0D;
                case "FL3/4x7/8":
                    return 2.23D;
                case "FL3/4x1":
                    return 2.55D;
                case "FL3/4x1 1/8":
                    return 2.87D;
                case "FL3/4x1 1/4":
                    return 3.19D;
                case "FL3/4x1 3/8":
                    return 3.51D;
                case "FL3/4x1 1/2":
                    return 3.83D;
                case "FL3/4x1 5/8":
                    return 4.14D;
                case "FL3/4x1 3/4":
                    return 4.46D;
                case "FL3/4x2":
                    return 5.1D;
                case "FL3/4x2 1/4":
                    return 5.74D;
                case "FL3/4x2 1/2":
                    return 6.38D;
                case "FL3/4x2 3/4":
                    return 7.01D;
                case "FL3/4x3":
                    return 7.65D;
                case "FL3/4x3 1/4":
                    return 8.29D;
                case "FL3/4x3 1/2":
                    return 8.93D;
                case "FL3/4x4":
                    return 10.2D;
                case "FL3/4x4 1/2":
                    return 11.48D;
                case "FL3/4x5":
                    return 12.75D;
                case "FL3/4x5 1/2":
                    return 14.03D;
                case "FL3/4x6":
                    return 15.3D;
                case "FL3/4x7":
                    return 17.85D;
                case "FL3/4x8":
                    return 20.4D;
                case "FL1x1 1/4":
                    return 4.25D;
                case "FL1x1 1/2":
                    return 5.1D;
                case "FL1x1 3/4":
                    return 5.95D;
                case "FL1x2":
                    return 6.8D;
                case "FL1x2 1/4":
                    return 7.65D;
                case "FL1x2 1/2":
                    return 8.5D;
                case "FL1x2 3/4":
                    return 9.35D;
                case "FL1x3":
                    return 10.2D;
                case "FL1x3 1/4":
                    return 11.05D;
                case "FL1x3 1/2":
                    return 11.9D;
                case "FL1x4":
                    return 13.6D;
                case "FL1x4 1/2":
                    return 15.3D;
                case "FL1x5":
                    return 17.0D;
                case "FL1x5 1/2":
                    return 18.7D;
                case "FL1x6":
                    return 20.4D;
                case "FL1x7":
                    return 23.8D;
                case "FL1x8":
                    return 27.2D;
                case "FL1 1/4x1 1/2":
                    return 6.38D;
                case "FL1 1/4x1 3/4":
                    return 7.44D;
                case "FL1 1/4x2":
                    return 8.5D;
                case "FL1 1/4x2 1/4":
                    return 9.56D;
                case "FL1 1/4x2 1/2":
                    return 10.63D;
                case "FL1 1/4x2 3/4":
                    return 11.69D;
                case "FL1 1/4x3":
                    return 12.75D;
                case "FL1 1/4x3 1/4":
                    return 13.81D;
                case "FL1 1/4x3 1/2":
                    return 14.88D;
                case "FL1 1/4x4":
                    return 17.0D;
                case "FL1 1/4x4 1/2":
                    return 19.13D;
                case "FL1 1/4x5":
                    return 21.25D;
                case "FL1 1/4x5 1/2":
                    return 23.38D;
                case "FL1 1/4x6":
                    return 25.6D;
                case "FL1 1/4x8":
                    return 34.0D;
                case "FL1 1/2x1 3/8":
                    return 8.93D;
                case "FL1 1/2x2":
                    return 10.2D;
                case "FL1 1/2x2 1/4":
                    return 11.48D;
                case "FL1 1/2x2 1/2":
                    return 12.75D;
                case "FL1 1/2x2 3/4":
                    return 14.03D;
                case "FL1 1/2x3":
                    return 15.3D;
                case "FL1 1/2x3 1/4":
                    return 16.57D;
                case "FL1 1/2x3 1/2":
                    return 17.85D;
                case "FL1 1/2x4":
                    return 20.4D;
                case "FL1 1/2x4 1/2":
                    return 22.95D;
                case "FL1 1/2x5":
                    return 25.5D;
                case "FL1 1/2x5 1/2":
                    return 28.05D;
                case "FL1 1/2x6":
                    return 30.6D;
                case "FL1 1/2x8":
                    return 40.8D;
                case "FL2x2 1/4":
                    return 15.3D;
                case "FL2x2 1/2":
                    return 17.0D;
                case "FL2x2 3/4":
                    return 18.7D;
                case "FL2x3":
                    return 20.4D;
                case "FL2x3 1/2":
                    return 23.8D;
                case "FL2x4":
                    return 27.2D;
                case "FL2x4 1/2":
                    return 30.6D;
                case "FL2x5":
                    return 34.0D;
                case "FL2x5 1/2":
                    return 37.4D;
                case "FL2x6":
                    return 40.8D;
                case "FL2x8":
                    return 54.4D;
                default:
                    MessageBox.Show(@"The Material size not found", material, MessageBoxButtons.OK,
                                    MessageBoxIcon.Stop);
                    return 0;
            }
        }

        private static double PlateMaterial(string material)
        {
            switch (material)
            {
                case "PL10":
                    return 408D;
                case "PL9":
                    return 367.2D;
                case "PL8":
                    return 326.4D;
                case "PL7 1/2":
                    return 306D;
                case "PL7":
                    return 285.6D;
                case "PL6 1/2":
                    return 265.2D;
                case "PL6":
                    return 244.8D;
                case "PL5 1/2":
                    return 224.62D;
                case "PL5":
                    return 204.2D;
                case "PL4 3/4":
                    return 193.99D;
                case "PL4 1/2":
                    return 183.78D;
                case "PL4 1/4":
                    return 173.57D;
                case "PL4":
                    return 163.2D;
                case "PL3 3/4":
                    return 153D;
                case "PL3 1/2":
                    return 142.8D;
                case "PL3 1/4":
                    return 132.6D;
                case "PL3":
                    return 122.4D;
                case "PL2 3/4":
                    return 112.2D;
                case "PL2 1/2":
                    return 102D;
                case "PL2 1/4":
                    return 91.8D;
                case "PL2":
                    return 81.6D;
                case "PL1 3/4":
                    return 71.4D;
                case "PL1 5/8":
                    return 66.3D;
                case "PL1 1/2":
                    return 61.26D;
                case "PL1 3/8":
                    return 56.1D;
                case "PL1 1/4":
                    return 51D;
                case "PL1 1/8":
                    return 45.9D;
                case "PL1":
                    return 40.8D;
                case "PL7/8":
                    return 35.7D;
                case "PL3/4":
                    return 30.6D;
                case "PL11/16":
                    return 28.05D;
                case "PL5/8":
                    return 25.5D;
                case "PL9/16":
                    return 22.95D;
                case "PL1/2":
                    return 20.4D;
                case "PL7/16":
                    return 17.85D;
                case "PL3/8":
                    return 15.3D;
                case "PL5/16":
                    return 12.75D;
                case "PL1/4":
                    return 10.2D;
                case "PL3/16":
                    return 7.65D;
                case "PL1/8":
                    return 5.1D;
                case "PL1/16":
                    return 2.55D;
                default:
                    MessageBox.Show(@"The Material size not found", material, MessageBoxButtons.OK,
                                    MessageBoxIcon.Stop);
                    return 0;
            }
        }

        private static double RoundbarMaterial(string material)
        {
            switch (material)
            {
                case "RB3/16":
                    return 0.094D;
                case "RB1/4":
                    return 0.167D;
                case "RB5/16":
                    return 0.261D;
                case "RB3/8":
                    return 0.376D;
                case "RB7/16":
                    return 0.511D;
                case "RB1/2":
                    return 0.668D;
                case "RB9/16":
                    return 0.845D;
                case "RB5/8":
                    return 1.04D;
                case "RB3/4":
                    return 1.5D;
                case "RB7/8":
                    return 2.04D;
                case "RB1":
                    return 2.67D;
                case "RB1 1/8":
                    return 3.38D;
                case "RB1 1/4":
                    return 4.17D;
                case "RB1 3/8":
                    return 5.05D;
                case "RB1 1/2":
                    return 6.01D;
                case "RB1 5/8":
                    return 7.05D;
                case "RB1 3/4":
                    return 8.18D;
                case "RB1 7/8":
                    return 9.39D;
                case "RB2":
                    return 10.68D;
                case "RB2 1/8":
                    return 12.06D;
                case "RB2 1/4":
                    return 13.52D;
                case "RB2 3/8":
                    return 15.06D;
                case "RB2 1/2":
                    return 16.69D;
                case "RB2 5/8":
                    return 18.4D;
                case "RB2 3/4":
                    return 20.2D;
                case "RB2 7/8":
                    return 22.07D;
                case "RB3":
                    return 24.03D;
                case "RB3 1/8":
                    return 26.08D;
                case "RB3 1/4":
                    return 28.21D;
                case "RB3 3/8":
                    return 30.42D;
                case "RB3 1/2":
                    return 32.71D;
                case "RB3 5/8":
                    return 35.09D;
                case "RB3 3/4":
                    return 37.55D;
                case "RB3 7/8":
                    return 40.1D;
                case "RB4":
                    return 42.73D;
                case "RB4 1/4":
                    return 48.23D;
                case "RB4 1/2":
                    return 54.08D;
                case "RB4 3/4":
                    return 60.25D;
                case "RB5":
                    return 66.76D;
                case "RB5 1/4":
                    return 73.6D;
                case "RB5 1/2":
                    return 80.78D;
                case "RB5 3/4":
                    return 88.29D;
                default:
                    MessageBox.Show(@"The Material size not found", material, MessageBoxButtons.OK,
                                    MessageBoxIcon.Stop);
                    return 0;
            }
        }

        private static double TubeSteelMaterial(string material)
        {
            switch (material)
            {
                case "HSS3x2x3/16":
                    return 5.594D;
                case "HSS8x3x3/16":
                    return 13.25D;
                case "HSS12x2x3/16":
                    return 17.084D;
                case "HSS3x2xx1/4":
                    return 7.114D;
                case "HSS8x3x1/4":
                    return 17.32D;
                case "HSS12x2x1/4":
                    return 22.42D;
                case "HSS3.5x2.5x3/16":
                    return 6.874D;
                case "HSS8x3x1/2":
                    return 31.81D;
                case "HSS12x3x1/4":
                    return 24.12D;
                case "HSS3.5x2.5x1/4":
                    return 8.814D;
                case "HSS8x3x5/16":
                    return 21.214D;
                case "HSS12x3x5/16":
                    return 29.674D;
                case "HSS4x2x3/16":
                    return 6.874D;
                case "HSS8x3x3/8":
                    return 24.934D;
                case "HSS12x4x3/16":
                    return 19.63D;
                case "HSS4x2x1/4":
                    return 8.814D;
                case "HSS8x4x3/16":
                    return 14.534D;
                case "HSS12x4x1/4":
                    return 25.82D;
                case "HSS4x2x5/16":
                    return 10.584D;
                case "HSS8x41/4":
                    return 19.024D;
                case "HSS12x4x5/16":
                    return 31.84D;
                case "HSS4x2x3/8":
                    return 12.174D;
                case "HSS8x4x5/16":
                    return 23.34D;
                case "HSS12x4x3/8":
                    return 37.69D;
                case "HSS4x3x3/16":
                    return 8.154D;
                case "HSS8x4x3/8":
                    return 27.48D;
                case "HSS12x4x1/2":
                    return 48.85D;
                case "HSS4x3x1/4":
                    return 10.514D;
                case "HSS8x4x1/2":
                    return 35.24D;
                case "HSS12x4x5/8":
                    return 59.32D;
                case "HSS4x3x5/16":
                    return 12.74D;
                case "HSS8x4x5/8":
                    return 62.26D;
                case "HSS12x6x3/16":
                    return 22.18D;
                case "HSS4x3x3/8":
                    return 14.714D;
                case "HSS8x6x3/16":
                    return 17.08D;
                case "HSS12x6x1/4":
                    return 29.23D;
                case "HSS5x2x3/16":
                    return 8.154D;
                case "HSS8x6x1/4":
                    return 22.42D;
                case "HSS12x6x5/16":
                    return 36.10D;
                case "HSS5x2x1/4":
                    return 10.514D;
                case "HSS8x6x5/16":
                    return 27.59D;
                case "HSS12x6x3/8":
                    return 42.79D;
                case "HSS5x2x5/16":
                    return 12.704D;
                case "HSS8x6x3/8":
                    return 32.58D;
                case "HSS12x6x1/2":
                    return 55.66D;
                case "HSS5x2x3/8":
                    return 14.724D;
                case "HSS8x6x1/2":
                    return 42.05D;
                case "HSS12x6x5/8":
                    return 67.82D;
                case "HSS5x3x3/16":
                    return 9.424D;
                case "HSS8x6x5/8":
                    return 51.80D;
                case "HSS12x8x3/16":
                    return 24.73D;
                case "HSS5x3x1/4":
                    return 12.21D;
                case "HSS9x3x3/16":
                    return 14.53D;
                case "HSS12x8x1/4":
                    return 32.63D;
                case "HSS5x3x1/2":
                    return 21.63D;
                case "HSS9x3x1/4":
                    return 19.00D;
                case "HSS12x8x5/16":
                    return 40.35D;
                case "HSS5x3x5/16":
                    return 14.83D;
                case "HSS9x5x3/16":
                    return 17.08D;
                case "HSS12x8x3/8":
                    return 47.90D;
                case "HSS5x3x3/8":
                    return 17.27D;
                case "HSS9x5x1/4":
                    return 22.42D;
                case "HSS12x8x1/2":
                    return 62.46D;
                case "HSS5x4x3/16":
                    return 10.7D;
                case "HSS9x5x5/16":
                    return 27.59D;
                case "HSS12x8x5/8":
                    return 76.33D;
                case "HSS5x4x1/4":
                    return 13.91D;
                case "HSS9x5x3/8":
                    return 32.58D;
                case "HSS12x10x1/4":
                    return 36.03D;
                case "HSS5x4x5/16":
                    return 16.96D;
                case "HSS9x5x1/2":
                    return 42.05D;
                case "HSS12x10x5/16":
                    return 44.6D;
                case "HSS5x4x3/8":
                    return 19.82D;
                case "HSS9x5x5/8":
                    return 50.79D;
                case "HSS12x10x3/8":
                    return 53.00D;
                case "HSS6x2x3/16":
                    return 9.42D;
                case "HSS9x7x3/16":
                    return 19.63D;
                case "HSS12x10x1/2":
                    return 69.26D;
                case "HSS6x2x1/4":
                    return 12.21D;
                case "HSS9x7x1/4":
                    return 25.82D;
                case "HSS14x4x1/4":
                    return 29.23D;
                case "HSS6x2x5/16":
                    return 14.83D;
                case "HSS9x7x5/16":
                    return 31.74D;
                case "HSS14x4x5/16":
                    return 36.10D;
                case "HSS6x2x3/8":
                    return 17.26D;
                case "HSS9x7x3/8":
                    return 37.69D;
                case "HSS14x4x3/8":
                    return 42.79D;
                case "HSS6x3x3/16":
                    return 10.70D;
                case "HSS9x7x1/2":
                    return 48.85D;
                case "HSS14x4x1/2":
                    return 55.66D;
                case "HSS6x3x1/4":
                    return 13.91D;
                case "HSS9x7x5/8":
                    return 59.32D;
                case "HSS14x6x1/4":
                    return 32.63D;
                case "HSS6x3x5/16":
                    return 16.96D;
                case "HSS10x2x3/16":
                    return 14.53D;
                case "HSS14x6x5/16":
                    return 40.35D;
                case "HSS6x3x3/8":
                    return 19.82D;
                case "HSS10x2x1/4":
                    return 19.02D;
                case "HSS14x6x3/8":
                    return 47.9D;
                case "HSS6x4x3/16":
                    return 11.97D;
                case "HSS10x2x5/16":
                    return 23.34D;
                case "HSS14x6x1/2":
                    return 62.46D;
                case "HSS6x4x1/4":
                    return 15.62D;
                case "HSS10x2x3/8":
                    return 27.48D;
                case "HSS14x6x5/8":
                    return 76.33D;
                case "HSS6x4x5/16":
                    return 19.08D;
                case "HSS10x3x3/16":
                    return 15.84D;
                case "HSS16x4x5/16":
                    return 40.35D;
                case "HSS6x4x3/8":
                    return 22.37D;
                case "HSS10x3x1/4":
                    return 20.72D;
                case "HSS16x4x3/8":
                    return 47.90D;
                case "HSS6x4x1/2":
                    return 28.43D;
                case "HSS10x3x5/16":
                    return 25.42D;
                case "HSS16x4x1/2":
                    return 62.46D;
                case "HSS6x5x3/16":
                    return 13.25D;
                case "HSS10x3x3/8":
                    return 30.02D;
                case "HSS16x8x5/16":
                    return 48.86D;
                case "HSS6x5x1/4":
                    return 17.32D;
                case "HSS10x4x3/16":
                    return 17.08D;
                case "HSS16x8x3/8":
                    return 58.10D;
                case "HSS6x5x5/16":
                    return 21.21D;
                case "HSS10x4x1/4":
                    return 22.42D;
                case "HSS16x8x1/2":
                    return 76.07D;
                case "HSS6x5x3/8":
                    return 24.93D;
                case "HSS10x4x5/16":
                    return 27.59D;
                case "HSS16x8x5/8":
                    return 93.34D;
                case "HSS7x3x3/16":
                    return 11.97D;
                case "HSS10x4x3/8":
                    return 32.58D;
                case "HSS16x12x5/16":
                    return 57.36D;
                case "HSS7x3x1/4":
                    return 15.62D;
                case "HSS10x4x1/2":
                    return 42.05D;
                case "HSS16x12x3/8":
                    return 68.31D;
                case "HSS7x3x5/16":
                    return 19.08D;
                case "HSS10x4x5/8":
                    return 52.00D;
                case "HSS16x12x1/2":
                    return 89.68D;
                case "HSS7x3x3/8":
                    return 22.37D;
                case "HSS10x5x1/4":
                    return 24.12D;
                case "HSS16x12x5/8":
                    return 110.36D;
                case "HSS7x4x3/16":
                    return 13.25D;
                case "HSS10x5x3/8":
                    return 35.14D;
                case "HSS18x6x5/16":
                    return 48.86D;
                case "HSS7x4x1/4":
                    return 17.32D;
                case "HSS10x5x1/2":
                    return 45.12D;
                case "HSS18x6x3/8":
                    return 58.10D;
                case "HSS7x4x5/16":
                    return 21.21D;
                case "HSS10x6x3/16":
                    return 19.63D;
                case "HSS18x6x1/2":
                    return 76.07D;
                case "HSS7x4x3/8":
                    return 24.93D;
                case "HSS10x6x1/4":
                    return 25.82D;
                case "HSS18x6x5/8":
                    return 93.34D;
                case "HSS7x4x1/2":
                    return 31.84D;
                case "HSS10x6x5/16":
                    return 31.84D;
                case "HSS20x4x5/16":
                    return 48.86D;
                case "HSS7x5x3/16":
                    return 14.53D;
                case "HSS10x6x3/8":
                    return 37.69D;
                case "HSS20x4x3/8":
                    return 58.1D;
                case "HSS7x5x1/4":
                    return 19.02D;
                case "HSS10x6x1/2":
                    return 48.85D;
                case "HSS20x4x1/2":
                    return 76.07D;
                case "HSS7x5x5/16":
                    return 23.34D;
                case "HSS10x6x5/8":
                    return 59.32D;
                case "HSS20x8x5/16":
                    return 57.36D;
                case "HSS7x5x3/8":
                    return 27.48D;
                case "HSS10x8x3/16":
                    return 22.18D;
                case "HSS20x8x3/8":
                    return 68.31D;
                case "HSS7x5x1/2":
                    return 35.24D;
                case "HSS10x8x1/4":
                    return 29.23D;
                case "HSS20x8x1/2":
                    return 89.68D;
                case "HSS8x2x3/16":
                    return 11.97D;
                case "HSS10x8x5/16":
                    return 36.10D;
                case "HSS20x8x5/8":
                    return 110.36D;
                case "HSS8x2x1/4":
                    return 15.62D;
                case "HSS10x8x3/8":
                    return 42.79D;
                case "HSS20x12x5/16":
                    return 65.87D;
                case "HSS8x2x5/16":
                    return 19.08D;
                case "HSS10x8x1/2":
                    return 55.66D;
                case "HSS20x12x3/8":
                    return 78.52D;
                case "HSS8x2x3/8":
                    return 22.37D;
                case "HSS10x8x5/8":
                    return 67.82D;
                case "HSS20x12x1/2":
                    return 103.30D;
                case "HSS20x12x5/8":
                    return 127.37D;
                default:
                    MessageBox.Show(@"The Material size not found", material, MessageBoxButtons.OK,
                                    MessageBoxIcon.Stop);
                    return 0;
            }
        }

    }
}