using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AI_Script : MonoBehaviour
{
    // Start is called before the first frame update
    public  GameObject room1,room2,room3;
    private static float[] probability_distribution = {0.25f,0.25f,0.25f,0.25f};
    private static int[] win_distribution = {0,0,0,0};
    //public bool[,] RoomsPuzzleTypes = new bool[3,4];

    void Start()
    {
        
    }

     public void make_decision(int[] success_distribution, int room_num) {
        GameObject current_room = room1;
        switch(room_num) {
            case 1:
                current_room = room1;
                break;
            case 2:
                current_room = room2;
                break;
            case 3:
                current_room = room3;
                break;
        }
        int number_of_types = 0;
        for (int j = 0; j < 4; ++j) {
            if (current_room.GetComponent<Puzzle_info>().puzzle_types[j]) {
                number_of_types++;
            }
        }
        for (int i = 0; i < 4; i++) {
            if (success_distribution[i] == 1) {
                win_distribution[i] = win_distribution[i] + success_distribution[i];
                probability_distribution[i] = probability_distribution[i] - number_of_types * 0.03f;
            }
            else {
                win_distribution[i] = win_distribution[i] + success_distribution[i];
                probability_distribution[i] = probability_distribution[i] - 0.03f;
            }
        }
        int largest_idx1 = 0, largest_idx2 = 0, largest_idx3 = 0;
        for (int i = 0; i < 4; ++i) {
            if (probability_distribution[i] > probability_distribution[largest_idx1]) {
                largest_idx1 = i;
            }
        }
        for (int i = 0; i < 4 && i != largest_idx1; ++i) {
            if (probability_distribution[i] > probability_distribution[largest_idx2]) {
                largest_idx2 = i;
            }
        }
        for (int i = 0; i < 4 && i != largest_idx1 && i != largest_idx2; ++i) {
            if (probability_distribution[i] > probability_distribution[largest_idx3]) {
                largest_idx3 = i;
            }
        }
        if (room2.GetComponent<Puzzle_info>().puzzle_types[largest_idx1] == true && room2.GetComponent<Puzzle_info>().puzzle_types[largest_idx2] == true && room2.GetComponent<Puzzle_info>().puzzle_types[largest_idx3] == true) {
            SceneManager.LoadScene("Scene2", LoadSceneMode.Single);
        }
        else if (room3.GetComponent<Puzzle_info>().puzzle_types[largest_idx1] == true && room3.GetComponent<Puzzle_info>().puzzle_types[largest_idx2] == true && room3.GetComponent<Puzzle_info>().puzzle_types[largest_idx3] == true) {
            SceneManager.LoadScene("Scene3", LoadSceneMode.Single);
        }
        else if (room2.GetComponent<Puzzle_info>().puzzle_types[largest_idx1] == true && room2.GetComponent<Puzzle_info>().puzzle_types[largest_idx2] == true) {
            SceneManager.LoadScene("Scene2", LoadSceneMode.Single);
        }
        else if (room3.GetComponent<Puzzle_info>().puzzle_types[largest_idx1] == true && room3.GetComponent<Puzzle_info>().puzzle_types[largest_idx2] == true) {
            SceneManager.LoadScene("Scene3", LoadSceneMode.Single);
        }
        else if (room2.GetComponent<Puzzle_info>().puzzle_types[largest_idx1] == true) {
            SceneManager.LoadScene("Scene2", LoadSceneMode.Single);
        }
        else if (room3.GetComponent<Puzzle_info>().puzzle_types[largest_idx1] == true) {
            SceneManager.LoadScene("Scene3", LoadSceneMode.Single);
        }
        else {
            SceneManager.LoadScene("Scene4", LoadSceneMode.Single);
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
