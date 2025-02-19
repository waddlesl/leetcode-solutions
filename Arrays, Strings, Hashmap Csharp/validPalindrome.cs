class Solution(object):
    def isPalindrome(self, s):
        if s.strip() == "":
            return True
       
        cleanText = re.sub(r"[^A-Za-z0-9]","",s).lower()
       
        if cleanText == cleanText[::-1]:
            return True
        else:
            return False