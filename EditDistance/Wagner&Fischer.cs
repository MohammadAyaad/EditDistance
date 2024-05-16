namespace EditDistance
{
    public static class StringEditDistance
    {
        public static int getEditDistance(string str0, string str1)
        {
            int[,] distance_matrix = new int[(str0.Length + 1), (str1.Length + 1)];

            for (int i = 0; i <= str0.Length; i++)
                distance_matrix[i, 0] = i;

            for (int i = 0; i <= str1.Length; i++)
                distance_matrix[0, i] = i;

            for (int x = 1; x <= str0.Length; x++)
                for (int y = 1; y <= str1.Length; y++)
                    distance_matrix[x, y] = Math.Min(distance_matrix[x - 1, y], Math.Min(distance_matrix[x, y - 1], distance_matrix[x - 1, y - 1])) + ((str0[x - 1] == str1[y - 1]) ? 0 : 1);

            return distance_matrix[(str0.Length), (str1.Length)];
        }
    }
}
