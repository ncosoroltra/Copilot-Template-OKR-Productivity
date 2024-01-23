# PowerBI Automation Toolkit - Copilot-Template-Productivity

Welcome to the PowerBI Automation Toolkit repository! This toolkit streamlines various tasks related to PowerBI reporting, including sentiment analysis, summarization, and GitHub report updates. Below is a guide on how to use the scripts and update your PowerBI reports effectively.

## Table of Contents

1. [Requirements](#requirements)
2. [Summarization](#summarization)
3. [Sentiment Analysis](#sentiment-analysis)
4. [Update Report from GitHub](#update-report-from-github)
5. [Import Weekly Survey Data to PowerBI](#import-weekly-survey-data-to-powerbi)
6. [Additional Tips](#additional-tips)
7. [Contributing](#contributing)
8. [License](#license)

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
