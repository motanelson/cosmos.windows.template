print("\033c\033[47;31m\n give me the .bmp file to compile")
a=input().strip()
b=a.replace(".bmp","")
print("\033[47;31m\n")
c="hello\n"
f1=open(a,"rb")
f=f1.read()
f1.close()
r=b''
counter=0
g=c.encode()
for ff in f:
   i=int(ff)
   ii=int(g[counter])
   fff=0xff & (i+ii)
   rr=bytearray([fff])
   r=r+rr
   counter=counter+1
   if counter>=len(g):
       counter=0

f1=open(b+".bmpcx","bw")
f1.write(r)
f1.close()