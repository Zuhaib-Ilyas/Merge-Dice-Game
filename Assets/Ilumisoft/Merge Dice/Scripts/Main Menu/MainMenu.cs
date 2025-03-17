using UnityEngine;
using UnityEngine.UI;

namespace Ilumisoft.MergeDice
{
    public class MainMenu : MonoBehaviour
    {
        [SerializeField] private GameObject MainMenuPanel;
        [SerializeField] private GameObject DailyRewardsPanel;


        [SerializeField] private Button DailyRewardsBtn;
        void Update()
        {
            if (IsReturnButtonDown())
            {
                QuitApplication();
            }
        }

        bool IsReturnButtonDown()
        {
            return Input.GetKeyDown(KeyCode.Escape);
        }

        void QuitApplication()
        {
            Application.Quit();
        }

        public void ShowDailyRewardsPanel()
        {
            MainMenuPanel.SetActive(false);
            DailyRewardsPanel.SetActive(true);
        }
    }
}