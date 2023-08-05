# Auto Repair Shop Management
An ASP.Net app to allow customers to book appointments, mechanics to complete job cards/inspections, and managers to perform numerous tasks in an automotive workshop environment.

# System Overview

![](https://lh3.googleusercontent.com/pw/AIL4fc_vjRoNtV7fKT5a8pAZfMPB6ln47LLtV7xLc6ZHMyVc8krj2x29iJsdkGLu8Jih5MNxOJbbQ2sks-4ExAnuXBY6shFf1ws7W2GBI-iDweBO88UcvDkpoYeFflbbW6n0P0mQLeH4ze6gW9M2_Nm8j0eP=w1011-h972-s-no)

This repository focuses solely on the Blazor Server App. [Click here for more information about the API](https://github.com/GusPietrasanta/auto-repair-shop-api), and [click here for more information about the Mobile Phone App](https://github.com/GusPietrasanta/auto-repair-shop-mobile-app) that form part of the project.

# Database Entity Relationship Diagram

![](https://lh3.googleusercontent.com/pw/AIL4fc9bmbdVe3za4EvJNRaCMHk3qJKQgkGZ94v6Z9nXV-j6vwSKEVdYRdK7v-09bhVTZmC2VIDPkf7NEhKq6fsh2iB-TX-02rwJBDqKdB3JTfZTotdg4puREkdFktwfacIYbbZfkqNejmNjbf4Oc_mRNNld=w977-h760-s-no)

# Blazor Web App Features

## For Users
- Book an appointment using the vehicle number plate and contact details.
- Access car reports history using the vehicle number plate and last name.

## For Mechanics
- Perform assigned car inspections and complete reports.
- Post messages to a message board to communicate with managers about different topics using tags.

## For Managers
- Search, view, and update customers and their cars.
- Search, view, and update vehicle details.
- Assign job cards/inspections to mechanics.
- View completed inspections.
- Check and update stock/inventory.
- Dashboard with multiple data, including:
  - Week schedule/incoming appointments.
  - Message board.
  - Analytics on most common brands, popular services, etc.
  - Low stock alarms (if any).

## Technology Stack

- C#
- LINQ
- HTML
- ASP.NET Blazor Server
- SQL Server
- NUnit
- Dapper
- Bootstrap
- Syncfusion UI Components
- A bit of JavaScript Interop

# Screenshots
  
# As customer:

## Booking an appointment

![Booking an appointment](https://lh3.googleusercontent.com/pw/AIL4fc8yg5RI1GgbQ7fSA_qXx08bYu8o3kdqdQfzfE-OHzHUBelcfi6fSb3beE0-RgBQiR5nh4Gi73QxXz5bk1F1JPP-1KEfBI1xgkhnTQX_TwF-KvOtnruZUp8t1lWwRv7PO1LOSGp18QZYpdCrzIfNR7-Q=w1627-h709-s-no)

## Searching past reports based on Last Name and Number Plate

![Searching past report](https://lh3.googleusercontent.com/pw/AIL4fc91Q7Qwf6TBK9Qf-3H0UqHAtyIddtOCvqEJud2mLEIfC63V2FcQbdd1ln1WUz2-Tz3xWMUbMqyg-66J576dSVXfiCmDl9rYShmXHiMUE8DRYeWgGmoyFw57ThrVuZHLCX3Wd7YVTlmgbVoTjtFqAqB0=w816-h859-s-no)

## Viewing Report

![Viewing report](https://lh3.googleusercontent.com/pw/AIL4fc-Xc6-FEd5rVMzBqFbkSg_DdUNDkd6jYNQfWOilfs_ClWTPNOQAxoKBIJLQNXtnRNXHfjOpN0QMbRBFIyMPytSyg_K6AHBeDdjCT9kpBmdv63ywCXo-YypcqZxGqpJkqfeLVf40xa40ByOIXCCLwUKS=w1110-h709-s-no)

# As mechanic:

## Completing Report

![Completing report](https://lh3.googleusercontent.com/pw/AIL4fc-g9M5wrmILA41O9t0aJitCtwgN-MdWOGofVaUczhvd4uZEt5jULlkEjdYkg0mVxoxKf2vx7zNx3ZZVeTqre9S_pRe7P66ewgM480mLTwMC9djc7gJYoNArIuoAnQEeHVAtS4ZiN23qgeS87TMaRRzg=w786-h715-s-no)

# As manager:

## Dashboard

### Manager's dashboard contains information about today's appointments, messages that the mechanics sent, completed reports and warnings about inventory items and their stock status.

![Manager dashboard 1](https://lh3.googleusercontent.com/pw/AIL4fc9IQRcJIs8HMH6ACNP6-RqcJ9vaFBShY-AjAr-yVGQW-73jS_Q5Pn1lgpaB_XJo0-aCKWVG3QXBBti-qpXQWGUrobV5OakCyECT5gz-AQWX-cys-4mXKxueAcjYH6Mlua8Wg93CamJfglJyAEHJmJPB=w1193-h580-s-no)

![Manager dashboard 2](https://lh3.googleusercontent.com/pw/AIL4fc-9Vx8-ACyMb0ole2IWyA8DZVUCgj9j-0vPWx_p-h_VxOK9yZW9ESxm60gguzTiAWQKXwpQSzWX7Lps1ixtuuuVxg4Oqwy0-4BPm7jQIHcpDvRpO0QKXmnbxBFT8cA0-0N8Ymo5C6KyzEBgHLnJObcr=w1193-h578-s-no)

### It also contains some analytics retrieved from the Database, such as cars by maker and most common issues found during inspections

![A couple of graphs showing some information from the database](https://lh3.googleusercontent.com/pw/AIL4fc_vRJIyvair3OVan0niwRnZuRHIUNM-fd_qqJP28kXb5Tjb7oGBnTlG4Lsr8732lnFFxdkfk6HAkTLnxZxyBHRp70xBrzIYDA3uNogyGamCOW2BBfRu3jfJJWebWTm398YQrnuLvmALbH0TGeE_xIic=w1193-h452-s-no)

### From the dashboard, the manager can perform some tasks

![Assigning job cards to mechanics](https://lh3.googleusercontent.com/pw/AIL4fc9Firs252vCBdOVmlZN6cqAOZVd4ztgirnckQXBYGyjso6zBbwWb85Ho2rby8ZCI9V8W4srGG-Cdmg9GBlnfX30AEBIlDZXGeGwJesY0ACmGK770Bnv9CmU74z7aMremabbjcK67OaAB4wxykk4ApIr=w612-h393-s-no)

![Marking messages as read](https://lh3.googleusercontent.com/pw/AIL4fc9YgC4dTB-9I9NeGzMQNgU_pQMJZpgKxPOPzQxs4XCAal0WmoahNF5gEPK_h0kMkrSMKSYWLsppvzoPYAorEd3o3z38JuxqpZvQiDCQ_iFargQw49Lntd1VK8Ro9E1-atmcLBSaCbQoZv3wzRtwQkKc=w642-h508-s-no)

### There is also a search bar that searches among customers, vehicles or inventory items.

![Search bar](https://lh3.googleusercontent.com/pw/AIL4fc9k9eipeVSwE88gDYKjr1C-QSDtC_L4lCTAIn40hs6Q0pqx3iHAlSgZTMzquhz7rpo7Km-NqgX7yvVUwLZobjRmtygQ10zMaspwa9aPnJvVZ3f99ILSCgn15_ic8nR7h-Yo9Iu-akmUQmEp7MqLDbsf=w827-h596-s-no)

## Manager's Report Page

![Report page for manager](https://lh3.googleusercontent.com/pw/AIL4fc8E39pdo_lA7VhpKEheB26WJSiIEJWNMwzHQh_BLd5nlfEWnQRUs-bB0TEcC2Mu5o_haWuso2wJk9HlHTRDRUaYV6qj8X8TKYQEFs9-Lr8asgkXTprW9s83DeOMG4wouvoNvsi4C3yu827IWHoRUEVF=w1193-h439-s-no)

## Inventory Items Update

![Updating an item from the inventory](https://lh3.googleusercontent.com/pw/AIL4fc-L96PB73RuDG1jlSQF_cmv_CQLrx4rNISgff18x3GO-vD88lznjH4LJAKn7Q_sWooBUY0JNs9uvhBmvvgf9aijeUhA-VjohvQ6Wx4TM0HdHpeltlSxtSzB2pD_f3juCriNzElq08CGBccvYjBnkBLD=w1193-h546-s-no)

# Search Vehicles by any paramter

## Search a vehicle by any attribute: make, model, year, fuel type, number plate, etc.

![Searching vehicles](https://lh3.googleusercontent.com/pw/AIL4fc-drcZ574anY5jgeTYN-1hZdMdOdL39jOw03ghHBf5bC9LdqGjoT0PFGBMuSTEAfI6begHM0XCF9wsmkKibPfe61qw3fXPiDoVf7yFN0BLKg1-m2w5aIiXV7mLAroMK47uXNEODKYWkyJJqGB9fneBL=w814-h759-s-no)

# Vehicle Page

## From the vehicle page, the manager can edit vehicle details and access past report for that particular vehicle.

![Vehicle page](https://lh3.googleusercontent.com/pw/AIL4fc_J3Oc_OYqB5Vl0ETs7zRF7YpsgpYQVRayZ0fmOVd-c10ng878q82-hWH9t-0iNVAXjLJlccgk8yVh2lN1Z7RO6H2BB37mwrmEGBsblPPEmsGvr9IfWUNYUYYhpL_Pp1SDu9yj6xxN0cwX_X0DBUzPl=w1193-h694-s-no)

# Customer Page

## From the customer page, the manager can edit customer information, and have access to all their vehicles.

![Customer page](https://lh3.googleusercontent.com/pw/AIL4fc931b1d88CYfRZkqNh_ErMAg-RAoZErKTf3l20A9dN4Pen0yI0eZJmw92DBpgEvkL_5EBZxDkAuxYDc_uxi0n3V3OgrCGlYI5vDsJsVufdIniwqhf601px4-u5PAQJa6bCEewUkOBp0tJHTRp_L5mbc=w1178-h763-s-no)

## Navigation History saved on Manager's session

![](https://lh3.googleusercontent.com/pw/AIL4fc8vq_6y350IAA5NQvlRxmATVRfl3U5bQvgCqzMDr3fWDJDIhym-7ekEHu8fxnyiQtSQJS7TaIz8HDnKdDjpRxmS6YbzsDb2yeWzP6i9LEW-dGTWsnnWsGFWQ_bUWtCjc7zQOe4RQ6xW5tdH1g_Pl_DD=w935-h610-s-no)

# Unit Testing 

![](https://lh3.googleusercontent.com/pw/AIL4fc8GxGAxRN4wY5DDMto-DHogl1i088VprhSxN07KSO65AnN65GZ5mE4hl_lRZIQSEOP4zJs-jIvKW9upPeE4qo9oHm7OtBt7kLtrnzaEq02E2i2x3VBwdQmdk7oXfpmBsWh_uAEtNTQhNzDGE-MGhjZ_=w1203-h918-s-no)

# Integration Testing

![](https://lh3.googleusercontent.com/pw/AIL4fc_BHdXxlOrrgaqGUgDPE974hJuujTs7oBn72kwd3eSUE78BGKG9Q-xdqdncfu_w-A_i8S3ec7A1jwCAGrE-yB_cCRDrK7ekGkuXpLWIrAzancinEHmvpva5YdVvW5Kk6X7LWVFYEeISGjxJqh6UqnPH=w593-h491-s-no)

# Deployed to Azure

## Testing Inventory Updates

![](https://lh3.googleusercontent.com/pw/AIL4fc8tzozYCL91opoK-F7m6L9G4s_k_VwVXAHVCNDstW8Nnivq5KYhqS2en-gO7rLCFNDiSMQIeaABi7q67c9QOts9qhGY-e6ZGNjT0KtFPsaBkDyfbI8VEUe3Wl2mrqftDvNaTzAqfNgzD78mySfjk9LT=w1135-h773-s-no)


## Testing Search Feature

![](https://lh3.googleusercontent.com/pw/AIL4fc_eoO4W2owLQx6FW4dkJ5aTULGSW7qY9bVTcJy1qEtMzk00uQK0Rt8wA9zOgg_UFx0KESVA0gH4GRZt-yGzW_JCExW1m7mlcPlJ6TvBgeq62Uw-tfr48WwAMymYsbt_wUuWo2LKVYYhNKbMY8H6N7Kd=w1135-h773-s-no)

## Everything working together

![](https://lh3.googleusercontent.com/pw/AIL4fc_qDTlL_SmHqop5KzHfSqK3M3PAYdVpI5qzwrj_GaEIEr6A2djIBjL7FzTFNiOFwbCrHbj3Kr08bEr5eE3vIWYWWZtduXhfW1ZSguOtur3rK5KOUiheIhx5DdvYexeiZjvfAag_NJgP9yWe74XI9YnQ=w1824-h912-s-no)

# Licence

[MIT Licence] (http://opensource.org/licenses/MIT)
