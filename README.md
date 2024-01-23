# PowerBI Automation Toolkit 
# Copilot-Template-OKR-Productivity

Welcome to the PowerBI Automation Toolkit repository! This toolkit streamlines various tasks related to PowerBI reporting, including sentiment analysis, summarization, and GitHub report updates. Below is a guide on how to use the scripts and update your PowerBI reports effectively.

Table of Contents
Requirements
Summarization
Sentiment Analysis
Update Report from GitHub
Import Weekly Survey Data to PowerBI
Additional Tips
Contributing
License
Requirements
Before getting started, ensure you have the following tools and dependencies installed:

Python version 3.10.11
PowerBI Desktop
Visual Studio Code
Visual Studio 2022
.NET
Make sure to set up the correct environment variables in the provided Python scripts.

Summarization
The feedback_summarization.py script extracts relevant comments from a file named checkfeedback.txt and generates a summary in summary.txt. To execute the script, run:

bash
Copy code
python feedback_summarization.py
For more details, refer to the script path: C:\{your-folder-name}\Sample-Report-Refresh-PowerBI\scripts\feedback_summarization.py.

Sentiment Analysis
Sentiment analysis is performed using an Azure Language Studio instance. The dotnet script analyzes comments from a CSV file and appends sentiment scores. Execute the following command:

bash
Copy code
dotnet run <ruta-fichero-csv>
For proper data import to PowerBI, ensure the CSV file is saved as UTF-8.

Update Report from GitHub
The GH-ReportRecap.xlsx file is used to update the GitHub-related data in your PowerBI report. Make sure to follow the provided steps to add new data and refresh the GitHubReports table in PowerBI.

Import Weekly Survey Data to PowerBI
To import survey data, follow the steps outlined in the provided guidelines. Refresh tables after updating the relevant Excel files.

Additional Tips
Ensure correct API invocation and key settings.
For weekly summaries, maintain traceability in the Summary table.
Contributing
Feel free to contribute to this toolkit! Check out the contribution guidelines for more information.

License
This project is licensed under the MIT License.
