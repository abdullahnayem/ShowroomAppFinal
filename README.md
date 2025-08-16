# 🚗 Vehicle Showroom Management System

A console-based C# application demonstrating object-oriented programming concepts including inheritance, polymorphism, and encapsulation.

## 🛠️ Technologies

### Core Technologies
- **.NET 8.0** - Latest .NET framework with modern C# features
- **C# 12.0** - Modern programming language with advanced OOP capabilities
- **Console Application** - Cross-platform command-line interface

### Development Tools
- **Visual Studio 2022** / **VS Code** - IDE support
- **NuGet Package Manager** - Dependency management
- **Git** - Version control system

### Architecture & Design Patterns
- **Object-Oriented Programming (OOP)** - Core design philosophy
- **Inheritance** - Vehicle class hierarchy with specialized subclasses
- **Polymorphism** - Different vehicle types with unique behaviors
- **Encapsulation** - Proper data hiding and validation
- **SOLID Principles** - Clean separation of concerns
- **Abstract Classes** - Base vehicle class with abstract methods
- **Enumerations** - Engine type definitions

### Code Quality & Documentation
- **XML Documentation** - Comprehensive code documentation
- **IntelliSense Support** - Enhanced development experience
- **Input Validation** - Robust error handling and data validation
- **Color-Coded Console Output** - Enhanced user experience

## ✨ Features

### 🚙 Vehicle Management
- **Multi-Type Vehicle Support**: Normal, Sports, and Heavy vehicles
- **Dynamic Vehicle Addition**: Add vehicles with type-specific properties
- **Smart Vehicle Removal**: Remove vehicles by model number
- **Comprehensive Display**: Color-coded vehicle listing with detailed information
- **Automatic Property Assignment**: Default values based on vehicle type

### 🎯 Business Logic
- **Visitor Count Tracking**: Automatic calculation based on vehicle types
- **Sports Vehicle Bonus**: +20 visitors per sports vehicle
- **Engine Type Restrictions**: Type-specific engine limitations
- **Real-time Updates**: Dynamic visitor count updates

### 🛡️ Data Validation & Security
- **Input Validation**: Comprehensive validation for all user inputs
- **Type Safety**: Strong typing with C# language features
- **Error Handling**: Graceful error handling with user-friendly messages
- **Data Integrity**: Ensures data consistency across operations

### 🎨 User Experience
- **Interactive Console Menu**: User-friendly navigation system
- **Color-Coded Output**: Visual distinction between vehicle types
- **Formatted Tables**: Clean, organized data presentation
- **Responsive Interface**: Real-time feedback for all operations

### 🔧 Technical Features
- **Modular Architecture**: Clean separation of concerns
- **Extensible Design**: Easy to add new vehicle types
- **Memory Management**: Efficient resource utilization
- **Cross-Platform**: Runs on Windows, macOS, and Linux

## 📖 Overview

This application manages a vehicle showroom with three types of vehicles, each with specific characteristics and business rules. The system tracks visitor expectations based on the types of vehicles in the showroom.

## 🚙 Vehicle Types

### Normal Vehicle
- **Properties**: All common vehicle properties
- **Engine Type**: Flexible (Oil, Gas, Diesel)
- **Special Features**: None
- **Visitor Impact**: No additional visitors

### Sports Vehicle
- **Properties**: All common properties + Turbo capability
- **Engine Type**: Restricted to Oil only
- **Special Features**: Turbo (Yes/No)
- **Visitor Impact**: +20 visitors per sports vehicle
- **Default Color**: Red

### Heavy Vehicle
- **Properties**: All common properties + Weight specification
- **Engine Type**: Restricted to Diesel only
- **Special Features**: Weight in tons
- **Visitor Impact**: No additional visitors
- **Default Color**: Grey

## 🎯 Core Features

- ✅ **Add Vehicles**: Add any type of vehicle with validation
- ✅ **Remove Vehicles**: Remove vehicles by model number
- ✅ **Display Vehicles**: Show all vehicles with color-coded details
- ✅ **Visitor Tracking**: Track expected visitors (base: 30, +20 per sports vehicle)
- ✅ **Input Validation**: Comprehensive input validation and error handling
- ✅ **User-Friendly Interface**: Color-coded console interface

## 🏗️ Architecture

### Inheritance Hierarchy
```
Vehicle (Abstract Base Class)
├── NormalVehicle
├── SportsVehicle
└── HeavyVehicle
```

### Key Design Patterns
- **Inheritance**: Vehicle hierarchy with specialized subclasses
- **Polymorphism**: Different vehicle types with unique behaviors
- **Encapsulation**: Proper data hiding and validation
- **SOLID Principles**: Clean separation of concerns

## 📁 Project Structure

```
ShowroomApp/
├── Models/
│   ├── Vehicle.cs              # Base abstract class
│   ├── NormalVehicle.cs        # Normal vehicle implementation
│   ├── SportsVehicle.cs        # Sports vehicle with turbo
│   ├── HeavyVehicle.cs         # Heavy vehicle with weight
│   └── EngineType.cs           # Engine type enumeration
├── Services/
│   └── Showroom.cs             # Main business logic
├── Utils/
│   └── InputHelper.cs          # Input validation utilities
├── Program.cs                  # Application entry point
└── README.md                   # This file
```

## 🚀 Getting Started

### Prerequisites
- .NET 8.0 SDK
- Visual Studio 2022 or VS Code

### Installation & Running
```bash
# Navigate to project directory
cd ShowroomApp

# Restore dependencies
dotnet restore

# Run the application
dotnet run
```

## 🎮 Usage

### Main Menu Options
1. **Add Vehicle** - Add a new vehicle to the showroom
2. **Remove Vehicle** - Remove a vehicle by model number
3. **Show Vehicles** - Display all vehicles with details
4. **Show Visitor Count** - Display expected visitor count
5. **Exit** - Close the application

### Adding Vehicles
1. Select vehicle type (Normal, Sports, Heavy)
2. Enter model number
3. Enter engine power
4. Enter tire size
5. For Normal vehicles: Select engine type
6. For Sports vehicles: Specify turbo availability
7. For Heavy vehicles: Enter weight in tons

## 📊 Business Rules

### Visitor Count Calculation
- **Base Count**: 30 visitors
- **Sports Vehicle Bonus**: +20 visitors per sports vehicle
- **Formula**: `30 + (Number of Sports Vehicles × 20)`

### Engine Type Restrictions
- **Normal Vehicle**: Any engine type (Oil, Gas, Diesel)
- **Sports Vehicle**: Oil engines only
- **Heavy Vehicle**: Diesel engines only

### Default Values
- **Normal Vehicle**: Color = White
- **Sports Vehicle**: Color = Red, Engine = Oil
- **Heavy Vehicle**: Color = Grey, Engine = Diesel

### Adding to Showroom
```csharp
var showroom = new Showroom();
showroom.AddVehicle(sportsCar);
showroom.ShowVehicles();
showroom.ShowVisitorCount();
```

## 🧪 Testing the Application

### Sample Test Cases
1. **Add Normal Vehicle**: Should accept any engine type
2. **Add Sports Vehicle**: Should force Oil engine, track turbo
3. **Add Heavy Vehicle**: Should force Diesel engine, track weight
4. **Visitor Count**: Should increase by 20 for each sports vehicle
5. **Remove Vehicle**: Should remove by model number
6. **Input Validation**: Should handle invalid inputs gracefully

## 📝 Documentation

All classes and methods are documented with XML comments for:
- IntelliSense support
- Code maintainability
- Professional development practices
