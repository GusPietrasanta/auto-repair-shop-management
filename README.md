# Auto Repair Shop Management
An ASP.Net app to allow customers to book appointments, mechanics to complete job cards/inspections, and managers to perform numerous tasks in an automotive workshop environment.

## Features

### Users
- [x] Book an appointment using the vehicle number plate and contact details.
- [x] Access car reports history using the vehicle number plate and last name.

### Mechanics
- [x] Perform assigned car inspections and complete reports.
- [x] Post messages to a message board to communicate with managers about different topics using tags.

### Managers
- [x] Search, view, and update customers and their cars.
- [x] Search, view, and update vehicle details.
- [x] Assign job cards/inspections to mechanics.
- [x] View completed inspections.
- [x] Check and update stock/inventory.
- [x] Have a dashboard with multiple data, including:
  - [x] Week schedule/incoming appointments.
  - [x] Message board.
  - [x] Analytics on customer preferences, popular services, etc.
  - [x] Low stock alarms (if any).

## Roadmap

- [x] Set up the project structure and database schema.
- [x] Enable users to book appointments.
- [x] Allow users to access car reports history.
- [x] Implement managers' ability to assign job cards/inspections to mechanics.
- [x] Implement mechanics' ability to perform car inspections and complete reports.
- [x] Enable mechanics to post messages to the message board.
- [x] Implement managers' ability to search, view, and update customers details and their cars.
- [x] Create a dashboard for managers with multiple data (e.g., week schedule, message board, low stock alarms).
- [x] Implement an universal search bar for managers, to search for vehicles, customers or inventory items.
- [x] Tidy up code
- [x] Improve visuals
- [ ] Develop and implement unit tests
- [ ] Dockerise
- [ ] Deploy to AWS!

## Technology Stack

- AWS
- C#
- LINQ
- HTML
- ASP.NET Blazor Server
- SQL Server
- Dapper
- Bootstrap
- Syncfusion UI Components
- A bit of JavaScript Interop ~~sadly~~

## Screenshots
<div align="center">
  
## As customer:

#### Booking an appointment

![Booking an appointment](https://lh3.googleusercontent.com/pw/AIL4fc8yg5RI1GgbQ7fSA_qXx08bYu8o3kdqdQfzfE-OHzHUBelcfi6fSb3beE0-RgBQiR5nh4Gi73QxXz5bk1F1JPP-1KEfBI1xgkhnTQX_TwF-KvOtnruZUp8t1lWwRv7PO1LOSGp18QZYpdCrzIfNR7-Q=w1627-h709-s-no)

#### Searching past reports based on Last Name and Number Plate

![Searching past report](https://lh3.googleusercontent.com/pw/AIL4fc91Q7Qwf6TBK9Qf-3H0UqHAtyIddtOCvqEJud2mLEIfC63V2FcQbdd1ln1WUz2-Tz3xWMUbMqyg-66J576dSVXfiCmDl9rYShmXHiMUE8DRYeWgGmoyFw57ThrVuZHLCX3Wd7YVTlmgbVoTjtFqAqB0=w816-h859-s-no)

#### Viewing Report

![Viewing report](https://lh3.googleusercontent.com/pw/AIL4fc-Xc6-FEd5rVMzBqFbkSg_DdUNDkd6jYNQfWOilfs_ClWTPNOQAxoKBIJLQNXtnRNXHfjOpN0QMbRBFIyMPytSyg_K6AHBeDdjCT9kpBmdv63ywCXo-YypcqZxGqpJkqfeLVf40xa40ByOIXCCLwUKS=w1110-h709-s-no)

## As mechanic:

#### Completing Report

![Completing report](https://lh3.googleusercontent.com/pw/AIL4fc-g9M5wrmILA41O9t0aJitCtwgN-MdWOGofVaUczhvd4uZEt5jULlkEjdYkg0mVxoxKf2vx7zNx3ZZVeTqre9S_pRe7P66ewgM480mLTwMC9djc7gJYoNArIuoAnQEeHVAtS4ZiN23qgeS87TMaRRzg=w786-h715-s-no)

## As manager:

### Dashboard

#### Manager's dashboard contains information about today's appointments, messages that the mechanics sent, completed reports and warnings about inventory items and their stock status.

![Manager dashboard 1](https://lh3.googleusercontent.com/pw/AIL4fc9IQRcJIs8HMH6ACNP6-RqcJ9vaFBShY-AjAr-yVGQW-73jS_Q5Pn1lgpaB_XJo0-aCKWVG3QXBBti-qpXQWGUrobV5OakCyECT5gz-AQWX-cys-4mXKxueAcjYH6Mlua8Wg93CamJfglJyAEHJmJPB=w1193-h580-s-no)

![Manager dashboard 2](https://lh3.googleusercontent.com/pw/AIL4fc-9Vx8-ACyMb0ole2IWyA8DZVUCgj9j-0vPWx_p-h_VxOK9yZW9ESxm60gguzTiAWQKXwpQSzWX7Lps1ixtuuuVxg4Oqwy0-4BPm7jQIHcpDvRpO0QKXmnbxBFT8cA0-0N8Ymo5C6KyzEBgHLnJObcr=w1193-h578-s-no)

### It also contains some analytics retrieved from the Database, such as cars by maker and most common issues found during inspections

![A couple of graphs showing some information from the database](https://lh3.googleusercontent.com/pw/AIL4fc_vRJIyvair3OVan0niwRnZuRHIUNM-fd_qqJP28kXb5Tjb7oGBnTlG4Lsr8732lnFFxdkfk6HAkTLnxZxyBHRp70xBrzIYDA3uNogyGamCOW2BBfRu3jfJJWebWTm398YQrnuLvmALbH0TGeE_xIic=w1193-h452-s-no)

### From the dashboard, the manager can perform some tasks

![Assigning job cards to mechanics](https://lh3.googleusercontent.com/pw/AIL4fc9Firs252vCBdOVmlZN6cqAOZVd4ztgirnckQXBYGyjso6zBbwWb85Ho2rby8ZCI9V8W4srGG-Cdmg9GBlnfX30AEBIlDZXGeGwJesY0ACmGK770Bnv9CmU74z7aMremabbjcK67OaAB4wxykk4ApIr=w612-h393-s-no)

![Marking messages as read](https://lh3.googleusercontent.com/pw/AIL4fc9YgC4dTB-9I9NeGzMQNgU_pQMJZpgKxPOPzQxs4XCAal0WmoahNF5gEPK_h0kMkrSMKSYWLsppvzoPYAorEd3o3z38JuxqpZvQiDCQ_iFargQw49Lntd1VK8Ro9E1-atmcLBSaCbQoZv3wzRtwQkKc=w642-h508-s-no)

### There is also a search bar that searches among customers, vehicles or inventory items.

![Search bar](https://lh3.googleusercontent.com/pw/AIL4fc9k9eipeVSwE88gDYKjr1C-QSDtC_L4lCTAIn40hs6Q0pqx3iHAlSgZTMzquhz7rpo7Km-NqgX7yvVUwLZobjRmtygQ10zMaspwa9aPnJvVZ3f99ILSCgn15_ic8nR7h-Yo9Iu-akmUQmEp7MqLDbsf=w827-h596-s-no)

### Manager's Report Page

![Report page for manager](https://lh3.googleusercontent.com/pw/AIL4fc8E39pdo_lA7VhpKEheB26WJSiIEJWNMwzHQh_BLd5nlfEWnQRUs-bB0TEcC2Mu5o_haWuso2wJk9HlHTRDRUaYV6qj8X8TKYQEFs9-Lr8asgkXTprW9s83DeOMG4wouvoNvsi4C3yu827IWHoRUEVF=w1193-h439-s-no)

### Inventory Items Update

![Updating an item from the inventory](https://lh3.googleusercontent.com/pw/AIL4fc-L96PB73RuDG1jlSQF_cmv_CQLrx4rNISgff18x3GO-vD88lznjH4LJAKn7Q_sWooBUY0JNs9uvhBmvvgf9aijeUhA-VjohvQ6Wx4TM0HdHpeltlSxtSzB2pD_f3juCriNzElq08CGBccvYjBnkBLD=w1193-h546-s-no)

### Search Vehicles by any paramter

#### Search a vehicle by any attribute: make, model, year, fuel type, number plate, etc!

![Searching vehicles](https://lh3.googleusercontent.com/pw/AIL4fc-drcZ574anY5jgeTYN-1hZdMdOdL39jOw03ghHBf5bC9LdqGjoT0PFGBMuSTEAfI6begHM0XCF9wsmkKibPfe61qw3fXPiDoVf7yFN0BLKg1-m2w5aIiXV7mLAroMK47uXNEODKYWkyJJqGB9fneBL=w814-h759-s-no)

### Vehicle Page

#### From the vehicle page, the manager can edit vehicle details and access past report for that particular vehicle.

![Vehicle page](https://lh3.googleusercontent.com/pw/AIL4fc_J3Oc_OYqB5Vl0ETs7zRF7YpsgpYQVRayZ0fmOVd-c10ng878q82-hWH9t-0iNVAXjLJlccgk8yVh2lN1Z7RO6H2BB37mwrmEGBsblPPEmsGvr9IfWUNYUYYhpL_Pp1SDu9yj6xxN0cwX_X0DBUzPl=w1193-h694-s-no)

### Customer Page

#### From the customer page, the manager can edit customer information, and have access to all their vehicles.
![Customer page](https://lh3.googleusercontent.com/pw/AIL4fc931b1d88CYfRZkqNh_ErMAg-RAoZErKTf3l20A9dN4Pen0yI0eZJmw92DBpgEvkL_5EBZxDkAuxYDc_uxi0n3V3OgrCGlYI5vDsJsVufdIniwqhf601px4-u5PAQJa6bCEewUkOBp0tJHTRp_L5mbc=w1178-h763-s-no)

### Other Small Features

#### Update Customer Details directly from the Customer Search page
![](https://lh3.googleusercontent.com/pw/AIL4fc_7hCEpOLOWlzzqE6c3mWFkp2NZlTAEjzXJeIDggrwuyqvBghV1c21vk0pkGNms8Pr9iSk-6TQDq470W6xbGqTaJJvNVdpcl4jxg8YWKOfTAGc6Ax3d-BzIJc4qA2uSPhMJwgIfIEDFsZglkBshELFe=w1193-h481-s-no)

#### Access customer's vehicles from Customer Search page
![](https://lh3.googleusercontent.com/pw/AIL4fc-yzISgWmRk3wtWWMxpZl9JJ81ygdd2-P4yE4FTRomFl6v7xXPPbIeZncj2qRn1Wt1_66heTYjTwDoib_3ZlyYC2ChvIDTW2oUot4y2m1YTsHaCiXtWNqOiqjaoEvn_cFKaPP-Dm2KzTtJ1mZLq89fR=w1193-h276-s-no)

#### Pagination dependant on number of reports
![](https://lh3.googleusercontent.com/pw/AIL4fc9o9OEiUDrdOxto6FiU3ZEZbboHA_KmFjZ6XOamo2yV-A9jqxluNWVqiuqEuJ14yf4l91fL2_4vD0NkmAHSg_cy8IxRC_H6iR_SL6OuNIgVxK72Vmqtajeupua7vlXgBE4dlWo0yJZlUZGKjRw9Ce0E=w732-h312-s-no)

![](https://lh3.googleusercontent.com/pw/AIL4fc_ILzgPHWIyqrTBBohx7wG6KdN_WIh4JbhfSEz5XDhgWM20EaYULcUkYG-Or3A5AiFjyblqZQT6AAWe9LJq0qyN5MAp78sD1hqL1fgoM5pGo3DJa_x-BFtITNpA3pLRBksUyWtn47FvgkTX09QWHQhK=w755-h353-s-no)

![](https://lh3.googleusercontent.com/pw/AIL4fc_hHNaSUrgP9H1Bj3hxEksNO5xpu_HkrymMTk0KfZOdZ-rvWXxu50N0F2ZPNWvKwWEzJbGvhNBMJnOKtTfZztkgsLx4gMMCyoSm_3EeNvAMtF5Ix52nGTJrzflnRDIpP9UHZlMzQwhGxf2ZSaNVrVEW=w696-h330-s-no)

#### Navigation History saved on Manager's session
![](https://lh3.googleusercontent.com/pw/AIL4fc8vq_6y350IAA5NQvlRxmATVRfl3U5bQvgCqzMDr3fWDJDIhym-7ekEHu8fxnyiQtSQJS7TaIz8HDnKdDjpRxmS6YbzsDb2yeWzP6i9LEW-dGTWsnnWsGFWQ_bUWtCjc7zQOe4RQ6xW5tdH1g_Pl_DD=w935-h610-s-no)


</div>

## Licence

[MIT Licence] (http://opensource.org/licenses/MIT)
