using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace maandname;
    void findSeason(int M)
{

    // Checks out the season according
    // to the month number entered by the user
    switch (M)
    {
        case 12:
        case 1:
        case 2:
            cout << ("\nWINTER");
            break;
        case 3:
        case 4:
        case 5:
            cout << ("\nSPRING");
            break;
        case 6:
        case 7:
        case 8:
            cout << ("\nSUMMER");
            break;
        case 9:
        case 10:
        case 11:
            cout << ("\nAUTUMN");
            break;
        default:

            // Handles the condition if number entered
            // is not among the valid 12 months
            cout << ("\nInvalid Month number");
            break;
    }
}

// Driver code
int main()
{
    int M = 5;
    cout << "For Month number: " << M;
    findSeason(M);

    M = 10;
    cout << "\nFor Month number: " << M;
    findSeason(M);
    return 0;
}

// This code is contributed by Rajput-Ji
