// MFA (todo 需回傳 password 回後端註冊、驗證)

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
    "challenge": "ASjs-aCSf3EitxzWWvceEQ",
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
    "id": "yMsIcF4Yko6X_hSy-6bQk-JaBr0YfOy2lKWEpLkOrJA",
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
    "id": "yMsIcF4Yko6X_hSy-6bQk-JaBr0YfOy2lKWEpLkOrJA",
    "rawId": "yMsIcF4Yko6X_hSy-6bQk-JaBr0YfOy2lKWEpLkOrJA",
    "type": "public-key",
    "extensions": {
      
    },
    "response": {
      "AttestationObject": "o2NmbXRkbm9uZWdhdHRTdG10oGhhdXRoRGF0YVkBZ0mWDeWIDoxodDQXD2R2YFuP5K65ooYyx5lc87qDHZdjRQAAAAAAAAAAAAAAAAAAAAAAAAAAACDIywhwXhiSjpf-FLL7ptCT4loGvRh87LaUpYSkuQ6skKQBAwM5AQAgWQEA9kMJmFoA1aXfl4oKk6qpBvMaoHtWSWylu2vd-NfRq6r1w1S_lQUG3djZSCwNCCEk91L-PwCLFrctymiFFQyu8E14cbhj-_i3oAnF1sxyOzsRneumHLu1vg3yzhW5PLvinOgP-DzZjNKkUMFckVxcLeV42p3jsx4TS3aQP8SkYskTAXtxKzwtfHAsml_EfIsMeI_MRHBGxF7LCFA7o__Fy5F9m20_0qSIWv1HuHOpxS9hALNVt1FNHrrbalM8I3gRlitY11O12luVnyepBBJ-aXjq8qRUNegtnfrymQhuddwiatdiBHsWKQYJlyfS_jQyjj_8LCjvoyRERXeCuQ07MSFDAQAB",
      "clientDataJSON": "eyJ0eXBlIjoid2ViYXV0aG4uY3JlYXRlIiwiY2hhbGxlbmdlIjoiQVNqcy1hQ1NmM0VpdHh6V1d2Y2VFUSIsIm9yaWdpbiI6Imh0dHBzOi8vbG9jYWxob3N0OjcxODAiLCJjcm9zc09yaWdpbiI6ZmFsc2V9"
    }
}
```

res
```json
{
    "result": {
      "publicKey": "pAEDAzkBACBZAQCcloIbAzvbBiFhzWD7J_bhSQSOLe2uI2ZMetilZ2ll5Eee8k3BfjY1bvOiiMGGwlhbZWlrgcATUOWOdwjBtKzYOhDplznlXUBVlLuQUv0elf0-xmCTEY48ykplG-_zfylkG4eBu4rqcurd8wutTBqJXDE7s0R9LcgfgB-027jTRJSRdasuW682N0AtoOa-cgqc1Mg1SOZiz-hDTkFGqpNZeemsH5uskhzpkY9rd5AWApzWNkgvvk7nUqhja0CkECJ2-t4vGvoIv8NlGMjgcmvDGQSiu33W6hVMWat8342zBcOBdf9MsHhhmxOTFvwP3oriMkWE0zndJpqV6abWdQ4RIUMBAAE",
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
      "credentialId": "yMsIcF4Yko6X_hSy-6bQk-JaBr0YfOy2lKWEpLkOrJA",
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
    "challenge": "xiw9vY3hot2ncs7I-FeK8A",
    "timeout": 60000,
    "rpId": "localhost",
    "allowCredentials": [
      {
        "type": "public-key",
        "id": "BhD0H5o50C6bYUjkWOfbaeuTdoi7hfeqtNsaMAPJJ-c"
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
      "0": 198,
      "1": 44,
      "2": 61,
      "3": 189,
      "4": 141,
      "5": 225,
      "6": 162,
      "7": 221,
      "8": 167,
      "9": 114,
      "10": 206,
      "11": 200,
      "12": 248,
      "13": 87,
      "14": 138,
      "15": 240
    },
    "timeout": 60000,
    "rpId": "localhost",
    "allowCredentials": [
      {
        "type": "public-key",
        "id": {
          "0": 6,
          "1": 16,
          "2": 244,
          "3": 31,
          "4": 154,
          "5": 57,
          "6": 208,
          "7": 46,
          "8": 155,
          "9": 97,
          "10": 72,
          "11": 228,
          "12": 88,
          "13": 231,
          "14": 219,
          "15": 105,
          "16": 235,
          "17": 147,
          "18": 118,
          "19": 136,
          "20": 187,
          "21": 133,
          "22": 247,
          "23": 170,
          "24": 180,
          "25": 219,
          "26": 26,
          "27": 48,
          "28": 3,
          "29": 201,
          "30": 39,
          "31": 231
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
    "id": "BhD0H5o50C6bYUjkWOfbaeuTdoi7hfeqtNsaMAPJJ-c",
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
    "id": "BhD0H5o50C6bYUjkWOfbaeuTdoi7hfeqtNsaMAPJJ-c",
    "rawId": "BhD0H5o50C6bYUjkWOfbaeuTdoi7hfeqtNsaMAPJJ-c",
    "type": "public-key",
    "extensions": {
      
    },
    "response": {
      "authenticatorData": "SZYN5YgOjGh0NBcPZHZgW4_krrmihjLHmVzzuoMdl2MFAAAAAQ",
      "clientDataJSON": "eyJ0eXBlIjoid2ViYXV0aG4uZ2V0IiwiY2hhbGxlbmdlIjoieGl3OXZZM2hvdDJuY3M3SS1GZUs4QSIsIm9yaWdpbiI6Imh0dHBzOi8vbG9jYWxob3N0OjcxODAiLCJjcm9zc09yaWdpbiI6ZmFsc2V9",
      "signature": "ShcwAqINGqptNjB5_NQ7hc2SuRkk2ThGGMli7ohaHgV2Si6fAKqZWM9QykNaUWoTN_TZxPG_Qi6AkWzeuEICCve_Ra34mJGweXrIPQWzNrilGYNbYsudY2y5QR6CnSSPuL-sUUYbAuTkO1CSsfGbbHpPnDK3BwqGy6Zzzi-_x_mhgAadNDX6AZON1wKiPlQ3b_FO3gG-YXVtn8kfNS9GUxVh53UjiDZetBmKWEbZtyIMq8vLyRQ4s8eZatwLbSJbqFWNVMqHNO7ahE8fU0TimzCIxlRGP1t4UG11W453nAUFHVMiJ6y4if-SU7_PEtJsNDX-Jn6zpaNR5zyYQjdQoQ"
    }
}
```

res
```json
{
    "credentialId": "BhD0H5o50C6bYUjkWOfbaeuTdoi7hfeqtNsaMAPJJ+c=",
    "counter": 3,
    "status": "ok",
    "errorMessage": ""
}
```