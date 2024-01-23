#Note: The openai-python library support for Azure OpenAI is in preview.
import os
import openai

openai.api_type = "azure"
openai.api_base = "https://XXXXXX.openai.azure.com/"
openai.api_version = "2023-09-15-preview"
openai.api_key = "API_KEY"

def read_text_file(file_path):
  with open(file_path, "r") as file:
    text = file.read()
  return text

file_path = ".\checkfeedback.txt"
output_file_path = "summary.txt"
text = read_text_file(file_path)


#prompt = "Provide a Summary of the relevant customers feedback below (each line is feedback and is in Spanish) about the use of Copilot and also, provide a percentage of feedback like: satisfied, not satisfied, neutral, not used yet."
prompt ="Here is a list of customer feedbacks about the use of GitHub Copilot. Each line is a separate feedback from a different user. Provide a summary of all the most important and relevant feedbacks and a separate percentage distribution of feedbacks falling in the following categories: Satisfied, Not satisfied, Neutral, Copilot not used by user."
#prompt ="Here is a list of customer feedbacks about the use of GitHub Copilot. Each line is a separate feedback from a different user.For each of the feedbacks provide the category it is falling into. Categories are: Satisfied, Not satisfied, Neutral, Copilot was not used by user. "
prompt = prompt + "\n\n" + text

response = openai.Completion.create(
  engine="gpt-35-turbo",
  prompt=prompt,
  temperature=0.3,
  max_tokens=500,
  top_p=1,
  frequency_penalty=0,
  presence_penalty=0,
  best_of=1,
  stop=None)
  
summary = response.choices[0].text.strip()

with open(output_file_path, "w") as file:
    file.write(summary)


