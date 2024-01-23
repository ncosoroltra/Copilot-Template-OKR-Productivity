# PowerBI Automation Toolkit - Copilot-Template-Productivity

Welcome to the PowerBI Automation Toolkit repository! This toolkit streamlines various tasks related to PowerBI reporting, including sentiment analysis, summarization, and GitHub report updates. Below is a guide on how to use the scripts and update your PowerBI reports effectively.

## Table of Contents

1. [Requirements](#requirements)
2. [Summarization](#summarization)
3. [Sentiment Analysis](#sentiment-analysis)

## Requirements

Before getting started, ensure you have the following tools and dependencies installed:

- [Python version 3.10.11](https://www.python.org/downloads/release/python-31011/)
- [PowerBI Desktop](https://powerbi.microsoft.com/en-us/desktop/)
- [Visual Studio Code](https://code.visualstudio.com/)
- [Visual Studio 2022](https://visualstudio.microsoft.com/visual-cpp-build-tools/)
- [.NET](https://dotnet.microsoft.com/en-us/)

Make sure to set up the correct environment variables in the provided Python scripts.

## Summarization

The `feedback_summarization.py` script extracts relevant comments from a file named `checkfeedback.txt` and generates a summary in `summary.txt`. To execute the script, run:

```bash
python feedback_summarization.py
```


## Sentiment Analysis

To analyze developer comments, we utilize an instance of Azure Language Studio. The script reads each line from the input file and returns a score along with a label (negative, positive, neutral).

### Prerequisites

- Install `dotnet`.
- Navigate to the code folder.
- Run the following command:

```bash
dotnet run <ruta-fichero-csv>
```

Ensure the input file is a comma-delimited .csv containing columns obtained from the .xlsx Forms responses file:

ID
Start Time
End Time
Additional Comments

Input File Path: C:\{your-folder-name}\Sample-Report-Refresh-PowerBI\Input files\Input-Feedback-script.csv

To import data correctly into PowerBI, perform a "Save As" on the generated .csv file with UTF-8 format.

Output File: .csv UTF-8 (Adds two columns to the original table)

Update Feedback and Sentiment Analysis in PowerBI
- Modify the source file of the Sentiment Analysis table with the generated .csv file after running the script.
- Save the information and return to the report.
- Click on Close & Apply.

By following these steps, you can keep your PowerBI report up-to-date with sentiment analysis results.

For more detailed information and step-by-step instructions, please refer to the attached Readme file in PDF
