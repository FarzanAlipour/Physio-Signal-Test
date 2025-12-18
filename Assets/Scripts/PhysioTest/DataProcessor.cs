using System.IO;
using UnityEngine;

namespace PhysioTest
{
    public class DataProcessor : MonoBehaviour
    {
        public string inputFileName = "2_7-insufficient-rom.json";
        
        [ContextMenu("Run Processing")]
        public void ProcessData()
        {
            string path = Path.Combine(Application.streamingAssetsPath, inputFileName);
            Debug.Log($"Reading from: {path}");

            // TODO: TASK 3 - PIPELINE
            // 1. Read JSON file content.
            // 2. Deserialize into PoseRecording.
            // 3. Iterate through frames and apply PositionFilter to the wrist (Index 15).
            // 4. (Bonus) Visualize the difference between Raw and Filtered data.
        }

        private void OnDrawGizmos()
        {
            // Optional: Draw the trajectory lines here for visual debugging
        }
    }
}