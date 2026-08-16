---50. Find Users With Valid E-Mails
---Write a solution to find the users who have valid emails.
---A valid e-mail has a prefix name and a domain where:
---The prefix name is a string that may contain letters (upper or lower case), digits, underscore '_', period '.', and/or dash '-'. 
---The prefix name must start with a letter.
---The domain is '@leetcode.com'.
SELECT *
FROM Users
WHERE mail REGEXP '^[A-Za-z][A-Za-z0-9_.-]*@leetcode\\.com$'
AND mail NOT REGEXP '[^A-Za-z0-9_.@-]'
AND mail NOT LIKE '%#%@leetcode.com';

--Notes for myself, 'cause MySQL is weird
/*1.
REGEXP '^[A-Za-z]... checks if the email address starts with a letter (^[A-Za-z]), 
then allows alphanumeric characters, periods, underscores, and dashes ([A-Za-z0-9_.-]*) up to the @leetcode.com domain. 
Using \\. before com is necessary because . in the regular expression has a special meaning, so it must be escaped. 

2.
NOT REGEXP '[^A-Za-z0-9_.@-]' checks if there are any illegal characters in the 
email address other than alphanumerics, dot (.), underscore (_), hyphen (-), and the @ sign.

3.
NOT LIKE '%#%@leetcode.com' checks if the email address does not contain the # character before the @leetcode.com domain.*/