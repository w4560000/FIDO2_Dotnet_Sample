// Passwordless

註冊
1. /makeCredentialOptions (打後端API 取得憑證參數)

req
```json
{
    "username": "Leo",
    "attType": "none",
    "authType": "",
    "userVerification": "discouraged",
    "requireResidentKey": "false"
}
```

res
```json
{
    "rp": {
      "id": "localhost",
      "name": "FIDO2 Test"
    },
    "user": {
      "name": "Leo",
      "id": "TGVv",
      "displayName": null
    },
    "challenge": "Y4CAkQvaAlVHr1NtF9zfGw",
    "pubKeyCredParams": [
      {
        "type": "public-key",
        "alg": -7
      },
      {
        "type": "public-key",
        "alg": -257
      },
      {
        "type": "public-key",
        "alg": -37
      },
      {
        "type": "public-key",
        "alg": -35
      },
      {
        "type": "public-key",
        "alg": -258
      },
      {
        "type": "public-key",
        "alg": -38
      },
      {
        "type": "public-key",
        "alg": -36
      },
      {
        "type": "public-key",
        "alg": -259
      },
      {
        "type": "public-key",
        "alg": -39
      },
      {
        "type": "public-key",
        "alg": -8
      }
    ],
    "timeout": 60000,
    "attestation": "none",
    "authenticatorSelection": {
      "requireResidentKey": false,
      "userVerification": "discouraged"
    },
    "excludeCredentials": [
      
    ],
    "extensions": {
      "exts": true,
      "uvm": true
    },
    "status": "ok",
    "errorMessage": ""
}
```

2. navigator.credentials.create({
    publicKey: req
}) (Web API 建立憑證)

req
```json
{
    "rp": {
      "id": "localhost",
      "name": "FIDO2 Test"
    },
    "user": {
      "name": "Leo",
      "id": {
        
      },
      "displayName": null
    },
    "challenge": {
      
    },
    "pubKeyCredParams": [
      {
        "type": "public-key",
        "alg": -7
      },
      {
        "type": "public-key",
        "alg": -257
      },
      {
        "type": "public-key",
        "alg": -37
      },
      {
        "type": "public-key",
        "alg": -35
      },
      {
        "type": "public-key",
        "alg": -258
      },
      {
        "type": "public-key",
        "alg": -38
      },
      {
        "type": "public-key",
        "alg": -36
      },
      {
        "type": "public-key",
        "alg": -259
      },
      {
        "type": "public-key",
        "alg": -39
      },
      {
        "type": "public-key",
        "alg": -8
      }
    ],
    "timeout": 60000,
    "attestation": "none",
    "authenticatorSelection": {
      "requireResidentKey": false,
      "userVerification": "discouraged"
    },
    "excludeCredentials": [
      
    ],
    "extensions": {
      "exts": true,
      "uvm": true
    },
    "status": "ok",
    "errorMessage": ""
}
```

res
```json
{
    "authenticatorAttachment": "platform",
    "id": "lyPjeBvOqtydSKXwGRnculqabY4T51SxAALD0XM47yY",
    "rawId": ArrayBuffer
    "response" {
        "attestationObject": ArrayBuffer,
        "clientDataJSON" ArrayBuffer,
    },
    "type": "public-key"
}
```

3. /makeCredential (打後端API 儲存憑證)

req
```json
{
    "id": "lyPjeBvOqtydSKXwGRnculqabY4T51SxAALD0XM47yY",
    "rawId": "lyPjeBvOqtydSKXwGRnculqabY4T51SxAALD0XM47yY",
    "type": "public-key",
    "extensions": {
      
    },
    "response": {
      "AttestationObject": "o2NmbXRkbm9uZWdhdHRTdG10oGhhdXRoRGF0YVkBZ0mWDeWIDoxodDQXD2R2YFuP5K65ooYyx5lc87qDHZdjRQAAAAAAAAAAAAAAAAAAAAAAAAAAACA_axC3yPs-jqkkBA5rXsSOf3ldq4UmhLrWtCbNVB7u8KQBAwM5AQAgWQEA2MyPc8_stFW5rWJvL8EIIq5j9iU5BADTDoodLzzdibHTA8Fzab34wexQ-xkH339cI0kI8w5X6GxukOizsij_mJXXh68IR7rSFfBgGnpaR_CByqJ9i94Rb26K_gfVjoCbqL-g6GQ7Fq0WWWyyUuxNHPZVgvdfbpJXyCTDIJ07aA6YXqa6Syds_Sir9jmHxYuaG9oStJ6pMveQmfVEhNly8kdLquNR8mhWsCZbbqzgxZnLrS4OMQqeZZYqrROTnfT4fEMV99UKxdMiKmRGI42cpJaheHYGoDnEjoPhtRXynKjh6JSQhaNOrdBgZfmxvC7fRSgkAETOyJO4Iy-Xp0fAJSFDAQAB",
      "clientDataJSON": "eyJ0eXBlIjoid2ViYXV0aG4uY3JlYXRlIiwiY2hhbGxlbmdlIjoiWTRDQWtRdmFBbFZIcjFOdEY5emZHdyIsIm9yaWdpbiI6Imh0dHBzOi8vbG9jYWxob3N0OjcxODAiLCJjcm9zc09yaWdpbiI6ZmFsc2V9"
    }
}
```

res
```json
{
    "result": {
      "publicKey": "pAEDAzkBACBZAQCpvWCF71B72uZ2sSKIT-6QD198P0tVHFIgzNf8yhGJmunV_fyspUiO6EMa5kcRJsIfDlwDIf0jZnlMGwif0bAijVJAiAJSpaRgiJAY4Ti7fVyowJL3bBnOGFHhrKb42q796OUfOQExxlaWbkdL1X6s49N66zw9fCsUI1tJemq2KXzXxOCIxDsOLNEV4Jat5INUqFtmEtK70zmwR0g65Zp9qk0got5aVsnDYPpgrdkInhasJ-TGe9Nh-Dx10apmpnKxUcWY2r8Uvz_fkaaWMVpXNJAFCBOjYKH8-T-9vV9PfbNb2XFMUKohskr-K8Q2zM4M13U7aVIadXuKxyKSSOZRIUMBAAE",
      "user": {
        "name": "Leo",
        "id": "TGVv",
        "displayName": null
      },
      "credType": "none",
      "aaguid": "00000000-0000-0000-0000-000000000000",
      "attestationCertificate": null,
      "attestationCertificateChain": [
        
      ],
      "credentialId": "lyPjeBvOqtydSKXwGRnculqabY4T51SxAALD0XM47yY=",
      "counter": 0,
      "status": null,
      "errorMessage": null
    },
    "status": "ok",
    "errorMessage": ""
}
```

登入
1. /assertionOptions (打後端API 先驗證帳號是否存在，並回傳憑證參數)

req
```json
{
    "username": "Leo"
}
```

res
```json
{
    "challenge": "dybaF-5a8RzF1f60kwa0CA",
    "timeout": 60000,
    "rpId": "localhost",
    "allowCredentials": [
      {
        "type": "public-key",
        "id": "lyPjeBvOqtydSKXwGRnculqabY4T51SxAALD0XM47yY"
      }
    ],
    "userVerification": "discouraged",
    "extensions": {
      "exts": true,
      "uvm": true
    },
    "status": "ok",
    "errorMessage": ""
}
```

2. navigator.credentials.get({
    publicKey: req
}) (Web API 取得憑證)

req
```json
{
    "challenge": {
      "0": 119,
      "1": 38,
      "2": 218,
      "3": 23,
      "4": 238,
      "5": 90,
      "6": 241,
      "7": 28,
      "8": 197,
      "9": 213,
      "10": 254,
      "11": 180,
      "12": 147,
      "13": 6,
      "14": 180,
      "15": 8
    },
    "timeout": 60000,
    "rpId": "localhost",
    "allowCredentials": [
      {
        "type": "public-key",
        "id": {
          "0": 151,
          "1": 35,
          "2": 227,
          "3": 120,
          "4": 27,
          "5": 206,
          "6": 170,
          "7": 220,
          "8": 157,
          "9": 72,
          "10": 165,
          "11": 240,
          "12": 25,
          "13": 25,
          "14": 220,
          "15": 186,
          "16": 90,
          "17": 154,
          "18": 109,
          "19": 142,
          "20": 19,
          "21": 231,
          "22": 84,
          "23": 177,
          "24": 0,
          "25": 2,
          "26": 195,
          "27": 209,
          "28": 115,
          "29": 56,
          "30": 239,
          "31": 38
        }
      }
    ],
    "userVerification": "discouraged",
    "extensions": {
      "exts": true,
      "uvm": true
    },
    "status": "ok",
    "errorMessage": ""
}
```

res
```json
{
    "authenticatorAttachment": null,
    "id": "lyPjeBvOqtydSKXwGRnculqabY4T51SxAALD0XM47yY",
    "rawId": ArrayBuffer,
    "response": {
        "authenticatorData": ArrayBuffer,
        "clientDataJSON": ArrayBuffer,
        "signature": ArrayBuffer,
        "userHandle": ArrayBuffer
    },
    "type": "public-key"
}
```

3. /makeAssertion (將憑證傳回後端驗證)

req
```json
{
    "id": "lyPjeBvOqtydSKXwGRnculqabY4T51SxAALD0XM47yY",
    "rawId": "lyPjeBvOqtydSKXwGRnculqabY4T51SxAALD0XM47yY",
    "type": "public-key",
    "extensions": {
      
    },
    "response": {
      "authenticatorData": "SZYN5YgOjGh0NBcPZHZgW4_krrmihjLHmVzzuoMdl2MFAAAAAQ",
      "clientDataJSON": "eyJ0eXBlIjoid2ViYXV0aG4uZ2V0IiwiY2hhbGxlbmdlIjoiZHliYUYtNWE4UnpGMWY2MGt3YTBDQSIsIm9yaWdpbiI6Imh0dHBzOi8vbG9jYWxob3N0OjcxODAiLCJjcm9zc09yaWdpbiI6ZmFsc2V9",
      "signature": "UD-V8q7l5OVzQEKq_I1IKewFPxyDjn_KAGa2DWq7aYRAeKM-g0pG9RsdORvceUiv9l_aHc8YuluvrqFURKVwU1RJXVAnRmT2b0vtQOIpgMlSz_hiSPE78Nj_VhbGtueeYHOKj2zV_MhODGj7T2qKsacBgDxMtB_8DJiBnsrCIeoG-t3icOUD2AIGOpXzwX3yM3jLdRKA66yq1i3_yeToyl3RFqCtNC1phhzwxFPGVkmh1wNiEVMGtVIR2KbeQ5B48nmTBunOUB4D1r3qG59Wle-8SRkY6eOAJzYp8UZDxjMfnF1dXbuYtALbxdETqicpkEC4qHomyHr5vepo3AZk-w"
    }
}
```

res
```json
{
    "credentialId": "lyPjeBvOqtydSKXwGRnculqabY4T51SxAALD0XM47yY=",
    "counter": 3,
    "status": "ok",
    "errorMessage": ""
}
```