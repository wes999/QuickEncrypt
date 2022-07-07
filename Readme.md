# Requirements
- .NET Core 6

# Usage
## Encryption
`quickencrypt <algorithm> <file_name> <out_file>`

### Algorithms

|  Algorithm  |  Key Length  |  IV Length  | 	 Command      |
|-------------|--------------|-------------|------------------|
|  AES	      |	 32 	     |	16	   | encryptaes       |
|  DES	      |  8	     |  8	   | encryptdes	      |
|  RC2 	      |  16          |  8	   | encryptrc2	      |
|  Triple DES |  24 	     |  24         | encrypttripledes |



## Hashing
`quickencrypt <algorithm> <file_name>`



# License
QuickEncrypt is Licensed Under the MIT License

