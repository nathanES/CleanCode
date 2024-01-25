# Design pattern Structure

## Adapter

Bien sûr, examinons le design pattern Adapter en C# à travers des exemples concrets. Le pattern Adapter est utilisé pour permettre à deux interfaces incompatibles de travailler ensemble. Cela est réalisé en créant une classe intermédiaire qui relie une interface existante (l'adaptee) à une autre interface (le target) attendue par un client.

### Exemple 1: Adaptation d'un Système de Logging

Imaginons que vous ayez une application avec une interface de logging définie, mais vous voulez utiliser une bibliothèque de logging tierce qui a une interface différente.

#### 1. Interfaces Existantes et Tierces

```csharp
// Interface existante dans votre application
public interface ILogger
{
    void LogMessage(string message);
}

// Interface de la bibliothèque tierce
public class ThirdPartyLogger
{
    public void LogInfo(string info)
    {
        Console.WriteLine($"Info: {info}");
    }
}
```

#### 2. Création de l'Adapter

```csharp
// Adapter
public class LoggerAdapter : ILogger
{
    private readonly ThirdPartyLogger _thirdPartyLogger = new ThirdPartyLogger();

    public void LogMessage(string message)
    {
        _thirdPartyLogger.LogInfo(message);
    }
}
```

#### 3. Utilisation de l'Adapter

```csharp
public class Application
{
    private readonly ILogger _logger;

    public Application(ILogger logger)
    {
        _logger = logger;
    }

    public void Process()
    {
        _logger.LogMessage("Processing application...");
    }
}

// Dans une autre partie du code
var logger = new LoggerAdapter();
var app = new Application(logger);
app.Process();
```

### Exemple 2: Adaptation d'une Interface de Système de Fichiers

Supposons que vous ayez besoin d'utiliser une bibliothèque tierce pour la gestion des fichiers, mais son interface ne correspond pas à celle attendue par votre application.

#### 1. Interfaces Existantes et Tierces

```csharp
// Interface attendue par votre application
public interface IFileReader
{
    string ReadFile(string path);
}

// Interface de la bibliothèque tierce
public class ThirdPartyFileReader
{
    public byte[] GetFileBytes(string path)
    {
        return File.ReadAllBytes(path); // Lecture de fichier et renvoie des bytes
    }
}
```

#### 2. Création de l'Adapter

```csharp
// Adapter
public class FileReaderAdapter : IFileReader
{
    private readonly ThirdPartyFileReader _fileReader = new ThirdPartyFileReader();

    public string ReadFile(string path)
    {
        byte[] bytes = _fileReader.GetFileBytes(path);
        return Encoding.UTF8.GetString(bytes);
    }
}
```

#### 3. Utilisation de l'Adapter

```csharp
public void DisplayFileContent(string path)
{
    IFileReader fileReader = new FileReaderAdapter();
    string content = fileReader.ReadFile(path);
    Console.WriteLine(content);
}

// Dans une autre partie du code
DisplayFileContent("example.txt");
```

### Quand utiliser le Pattern Adapter

- **Interfaces Incompatibles** : Lorsque vous souhaitez utiliser une classe existante dont l'interface ne correspond pas à celle dont vous avez besoin.
- **Réutilisation de Code** : Pour réutiliser des classes existantes même si leurs interfaces ne correspondent pas à celles requises par le contexte actuel.
- **Intégration de Bibliothèques et Systèmes Externes** : Pour intégrer des bibliothèques ou des systèmes tiers sans modifier le code client.

### Avantages du Pattern Adapter

- **Séparation et Respect des Contrats** : Permet de séparer le code client des détails de l'implémentation de la bibliothèque tierce, respectant le principe de l'ouverture/fermeture.
- **Flexibilité et Réutilisabilité** : Offre une plus grande flexibilité en permettant de réutiliser des fonctionnalités et des services existants.

### Inconvénients

- **Complexité Additionnelle** : Peut ajouter une couche de complexité supplémentaire au code.
- **Maintenance** : Nécessite une maintenance supplémentaire, en particulier si les interfaces de l'adaptee changent.

Le pattern Adapter est donc idéal pour intégrer des systèmes ou des composants existants qui ont des interfaces incompatibles avec les exigences actuelles de votre application, sans avoir à refaire ou modifier ces composants.

## Bridge

Bien sûr, examinons le design pattern Bridge en C# à travers des exemples concrets. Le pattern Bridge est utilisé pour séparer l'abstraction d'une entité de son implémentation, de sorte que les deux puissent varier indépendamment. Ce pattern est particulièrement utile pour éviter une liaison permanente entre une abstraction et son implémentation, ce qui est utile dans les cas où l'implémentation doit être sélectionnée ou changée dynamiquement.

### Exemple 1: Système de Rendu de Formes

Supposons que vous ayez un système de rendu graphique qui peut dessiner différentes formes. Ces formes peuvent être rendues dans différents styles (par exemple, rendu raster ou vectoriel).

#### 1. Définition de l'Abstraction et de l'Implémentation

```csharp
// Abstraction
public abstract class Shape
{
    protected readonly IRenderer renderer;

    protected Shape(IRenderer renderer)
    {
        this.renderer = renderer;
    }

    public abstract void Draw();
}

// Implementor
public interface IRenderer
{
    void RenderCircle(float radius);
    void RenderSquare(float side);
}

// Concrete Implementations
public class RasterRenderer : IRenderer
{
    public void RenderCircle(float radius)
    {
        Console.WriteLine($"Drawing a circle in raster with radius {radius}");
    }

    public void RenderSquare(float side)
    {
        Console.WriteLine($"Drawing a square in raster with side {side}");
    }
}

public class VectorRenderer : IRenderer
{
    public void RenderCircle(float radius)
    {
        Console.WriteLine($"Drawing a circle in vector with radius {radius}");
    }

    public void RenderSquare(float side)
    {
        Console.WriteLine($"Drawing a square in vector with side {side}");
    }
}

// Refined Abstraction
public class Circle : Shape
{
    private readonly float radius;

    public Circle(float radius, IRenderer renderer) : base(renderer)
    {
        this.radius = radius;
    }

    public override void Draw()
    {
        renderer.RenderCircle(radius);
    }
}

public class Square : Shape
{
    private readonly float side;

    public Square(float side, IRenderer renderer) : base(renderer)
    {
        this.side = side;
    }

    public override void Draw()
    {
        renderer.RenderSquare(side);
    }
}
```

#### 2. Utilisation du Bridge

```csharp
// Choix de l'implémentation
IRenderer rasterRenderer = new RasterRenderer();
IRenderer vectorRenderer = new VectorRenderer();

// Création de formes avec des rendus différents
Shape circle = new Circle(5, rasterRenderer);
circle.Draw(); // Dessine un cercle avec le rendu raster

Shape square = new Square(4, vectorRenderer);
square.Draw(); // Dessine un carré avec le rendu vectoriel
```

### Exemple 2: Système de Gestion de Messages

Imaginons un système de gestion de messages qui peut envoyer des messages dans différents formats (par exemple, email, SMS).

#### 1. Définition de l'Abstraction et de l'Implémentation

```csharp
// Abstraction
public abstract class Message
{
    protected IMessageSender sender;

    protected Message(IMessageSender sender)
    {
        this.sender = sender;
    }

    public abstract void Send(string content);
}

// Implementor
public interface IMessageSender
{
    void SendMessage(string message);
}

// Concrete Implementations
public class EmailSender : IMessageSender
{
    public void SendMessage(string message)
    {
        Console.WriteLine($"Sending email: {message}");
    }
}

public class SMSSender : IMessageSender
{
    public void SendMessage(string message)
    {
        Console.WriteLine($"Sending SMS: {message}");
    }
}

// Refined Abstraction
public class TextMessage : Message
{
    public TextMessage(IMessageSender sender) : base(sender) { }

    public override void Send(string content)
    {
        sender.SendMessage(content);
    }
}
```

#### 2. Utilisation du Bridge

```csharp
// Choix de l'implémentation
IMessageSender emailSender = new EmailSender();
IMessageSender smsSender = new SMSSender();

// Envoi de messages via différents canaux
Message emailMessage = new TextMessage(emailSender);
emailMessage.Send("Hello via Email");

Message smsMessage = new TextMessage(smsSender);
smsMessage.Send("Hello via SMS");
```

### Quand utiliser le Pattern Bridge

- **Changement d'Implémentation** : Lorsque vous voulez éviter une liaison permanente entre une abstraction et son implémentation, et que vous avez besoin de changer l'implémentation dynamiquement.
- **Extension dans Deux Dimensions** : Si vous avez besoin d'ét

endre une classe dans deux dimensions indépendantes (par exemple, fonctionnalités et implémentations).

- **Partage d'Implémentations** : Pour partager des implémentations entre plusieurs objets.

### Avantages du Bridge

- **Découplage** : Découple l'abstraction de son implémentation, permettant de varier les deux indépendamment.
- **Flexibilité** : Offre une plus grande flexibilité en termes de choix de l'implémentation.

### Inconvénients

- **Complexité** : Peut augmenter la complexité du code en introduisant plusieurs niveaux d'abstraction.

Le pattern Bridge est donc idéal pour gérer des situations où vous avez besoin de séparer l'abstraction d'un objet de son implémentation, permettant des changements et des extensions flexibles sans affecter le client.
