# Design Pattern

## Abstract Factory

Dans un scénario où différentes implémentations concrètes dans un pattern Abstract Factory nécessitent des paramètres différents pour leur construction, vous pouvez adopter plusieurs approches. L'une des méthodes consiste à utiliser des objets de configuration spécifiques pour chaque type d'implémentation. Ces objets contiendraient toutes les informations nécessaires pour créer une instance de l'objet souhaité.

### Exemple : Connexion à Différentes Bases de Données avec Paramètres Spécifiques

Voici comment vous pouvez gérer une situation où une connexion MySQL nécessite des informations supplémentaires par rapport à une connexion SQL Server.

#### Définition des Objets de Configuration

```csharp
// Configuration commune pour toutes les bases de données
public abstract class DatabaseConfiguration
{
    public string ConnectionString { get; set; }
}

// Configuration spécifique pour SQL Server
public class SqlServerConfiguration : DatabaseConfiguration
{
    // Paramètres spécifiques à SQL Server
}

// Configuration spécifique pour MySQL
public class MySqlConfiguration : DatabaseConfiguration
{
    public string AdditionalInfo { get; set; }
    // Autres paramètres spécifiques à MySQL
}
```

#### Implémentation des Concrete Products

```csharp
public interface IDatabaseConnection
{
    void Connect();
}

public class SqlServerConnection : IDatabaseConnection
{
    public SqlServerConnection(SqlServerConfiguration config)
    {
        // Utiliser config pour initialiser la connexion
    }

    public void Connect()
    {
        // Logique de connexion
    }
}

public class MySqlConnection : IDatabaseConnection
{
    public MySqlConnection(MySqlConfiguration config)
    {
        // Utiliser config pour initialiser la connexion
    }

    public void Connect()
    {
        // Logique de connexion
    }
}
```

#### Implémentation des Concrete Factories

```csharp
public interface IDatabaseConnectionFactory
{
    IDatabaseConnection CreateConnection(DatabaseConfiguration config);
}

public class SqlServerConnectionFactory : IDatabaseConnectionFactory
{
    public IDatabaseConnection CreateConnection(DatabaseConfiguration config)
    {
        return new SqlServerConnection((SqlServerConfiguration)config);
    }
}

public class MySqlConnectionFactory : IDatabaseConnectionFactory
{
    public IDatabaseConnection CreateConnection(DatabaseConfiguration config)
    {
        return new MySqlConnection((MySqlConfiguration)config);
    }
}
```

#### Utilisation dans le Code Client

```csharp
public class Application
{
    public void Start()
    {
        IDatabaseConnectionFactory factory = GetFactoryBasedOnConfiguration();
        DatabaseConfiguration config = GetDatabaseConfiguration();

        var connection = factory.CreateConnection(config);
        connection.Connect();
    }

    private IDatabaseConnectionFactory GetFactoryBasedOnConfiguration()
    {
        // Logique pour choisir la factory
        // Retourner une instance de SqlServerConnectionFactory ou MySqlConnectionFactory
    }

    private DatabaseConfiguration GetDatabaseConfiguration()
    {
        // Récupérer et retourner la configuration appropriée
        // Retourner une instance de SqlServerConfiguration ou MySqlConfiguration
    }
}
```

Dans cet exemple, chaque type de base de données a sa propre classe de configuration qui étend une classe de base abstraite ou une interface. Les factories concrètes prennent ces objets de configuration et les utilisent pour créer les connexions appropriées.

### Avantages

- **Flexibilité** : Cette méthode est flexible et permet de gérer facilement des configurations différentes pour chaque type de connexion.
- **Extensibilité** : Le système peut être étendu à de nouvelles bases de données avec des configurations uniques sans modifier les factories existantes.

### Inconvénients

- **Complexité** : Le code devient plus complexe, surtout avec l'augmentation du nombre de types de bases de données et de configurations.
- **Casting** : Le casting des objets de configuration peut être source d'erreurs si mal géré.
  Le design pattern Factory Method et le design pattern Abstract Factory sont tous deux des patterns de création utilisés pour déléguer le processus de création d'objets, mais ils servent à des fins différentes et sont utilisés dans des contextes distincts. Voici une comparaison détaillée pour éclaircir la différence entre eux :

## Factory Method

Bien sûr, explorons le pattern Factory Method avec des exemples concrets en C#. Ce design pattern est utilisé pour déléguer la création d'objets à des sous-classes, permettant ainsi une plus grande flexibilité dans la détermination du type d'objets à créer.

### Exemple 1: Création de Connexions à Différentes Bases de Données

Imaginons une application qui doit supporter des connexions à différents types de bases de données comme SQL Server et MySQL.

#### 1. Définition de la classe Creator et de ses sous-classes

```csharp
// Creator
public abstract class DatabaseConnectionFactory
{
    // Factory Method
    public abstract IDatabaseConnection CreateConnection();
}

// Concrete Creator for SQL Server
public class SqlServerConnectionFactory : DatabaseConnectionFactory
{
    public override IDatabaseConnection CreateConnection()
    {
        return new SqlServerConnection();
    }
}

// Concrete Creator for MySQL
public class MySqlConnectionFactory : DatabaseConnectionFactory
{
    public override IDatabaseConnection CreateConnection()
    {
        return new MySqlConnection();
    }
}

// Product Interface
public interface IDatabaseConnection
{
    void Open();
}

// Concrete Product for SQL Server
public class SqlServerConnection : IDatabaseConnection
{
    public void Open()
    {
        Console.WriteLine("Opening SQL Server connection.");
    }
}

// Concrete Product for MySQL
public class MySqlConnection : IDatabaseConnection
{
    public void Open()
    {
        Console.WriteLine("Opening MySQL connection.");
    }
}
```

#### 2. Utilisation du Factory Method

```csharp
public class Application
{
    private readonly DatabaseConnectionFactory _factory;

    public Application(DatabaseConnectionFactory factory)
    {
        _factory = factory;
    }

    public void Start()
    {
        var connection = _factory.CreateConnection();
        connection.Open();
    }
}

// Dans une autre partie du code
var sqlServerFactory = new SqlServerConnectionFactory();
var app = new Application(sqlServerFactory);
app.Start();
```

### Exemple 2: Création de Différents Types de Comptes Utilisateur

Supposons que vous ayez une application avec différents types de comptes utilisateurs, comme `AdminUser` et `StandardUser`.

#### 1. Définition de la classe Creator et de ses sous-classes

```csharp
// Creator
public abstract class UserFactory
{
    public abstract IUser CreateUser();
}

// Concrete Creator for Admin User
public class AdminUserFactory : UserFactory
{
    public override IUser CreateUser()
    {
        return new AdminUser();
    }
}

// Concrete Creator for Standard User
public class StandardUserFactory : UserFactory
{
    public override IUser CreateUser()
    {
        return new StandardUser();
    }
}

// Product Interface
public interface IUser
{
    void DisplayInfo();
}

// Concrete Product for Admin User
public class AdminUser : IUser
{
    public void DisplayInfo()
    {
        Console.WriteLine("Admin User");
    }
}

// Concrete Product for Standard User
public class StandardUser : IUser
{
    public void DisplayInfo()
    {
    Console.WriteLine("Standard User");
    }
}
```

#### 2. Utilisation du Factory Method

```csharp
public void CreateUserAndDisplayInfo(UserFactory factory)
{
    var user = factory.CreateUser();
    user.DisplayInfo();
}

// Dans une autre partie du code
CreateUserAndDisplayInfo(new AdminUserFactory());
CreateUserAndDisplayInfo(new StandardUserFactory());
```

### Quand utiliser le Factory Method

1. **Flexibilité dans la Création d'Objets** : Lorsque le type exact d'objets à créer n'est pas déterminé à l'avance, mais dépend de la logique ou des paramètres fournis à l'exécution.

2. **Délégation de la Responsabilité de Création** : Lorsque la création d'objets doit être déléguée à des sous-classes pour permettre une plus grande flexibilité et éviter un couplage fort entre le créateur et les produits concrets.

### Avantages du Factory Method

- **Décentralisation de la Création** : Permet de décentraliser la décision de création d'objets.
- **Extension Facile** : Facilite l'ajout de nouveaux types d'objets sans modifier le code existant.

### Inconvénients

- **Peut Augmenter le Nombre de Classes** : Peut entraîner une augmentation du nombre de classes/sous-classes dans le système.

Le pattern Factory Method est donc idéal pour des situations où la création d'objets nécessite une flexibilité et une décentralisation, permettant aux sous-classes de définir quel objet sera créé.

## Factory Method Vs Abstract Factory

### Factory Method

- **Niveau d'Abstraction** : Le Factory Method opère à un niveau d'abstraction unique. Il crée un seul type d'objet.
- **Implémentation** : Dans ce pattern, une méthode dans une classe (souvent abstraite) est définie et conçue pour créer un objet. Les sous-classes peuvent redéfinir cette méthode pour créer des types d'objets différents.
- **Usage** : Il est utilisé quand une classe ne peut pas anticiper le type d'objets à créer et veut que ses sous-classes spécifient ces objets. Il est également utile quand les classes délèguent la responsabilité de création à plusieurs sous-classes.
- **Exemple** : Une application de gestion de base de données où chaque type de base de données nécessite un type de connexion différent. Une classe de connexion abstraite pourrait définir un Factory Method pour créer des connexions, et chaque sous-classe spécifiera quel type de connexion créer.

### Abstract Factory

- **Niveau d'Abstraction** : L'Abstract Factory opère à un niveau d'abstraction plus élevé et peut créer plusieurs types d'objets qui sont liés ou dépendants.
- **Implémentation** : Ce pattern utilise un ensemble d'interfaces ou de classes abstraites pour créer des familles d'objets sans spécifier leurs classes concrètes. Plusieurs Factory Methods peuvent être utilisés pour définir comment créer différents types d'objets.
- **Usage** : Il est utile lorsque le système doit être indépendant de la façon dont ses produits sont créés, composés et représentés, et lorsque le système est configuré avec une de plusieurs familles de produits.
- **Exemple** : Une application avec une interface utilisateur multiplateforme pourrait utiliser une Abstract Factory pour créer des ensembles de widgets (boutons, cases à cocher, etc.) spécifiques à la plateforme.

### Résumé de la Différence

- **Factory Method** : Crée un type d'objet. La méthode de création est généralement définie dans une interface et implémentée par des sous-classes.
- **Abstract Factory** : Crée des familles d'objets liés ou dépendants sans spécifier leurs classes concrètes. Il utilise plusieurs Factory Methods, chacun pour créer un type d'objet différent.

### Choix du Pattern

- Utilisez le **Factory Method** lorsque vous avez plusieurs classes avec une méthode commune pour créer un objet mais avec des implémentations différentes de cette méthode.
- Utilisez l'**Abstract Factory** lorsque vous travaillez avec des familles d'objets liés et que vous voulez garantir que les objets créés par une factory sont compatibles entre eux.

## Prototype

Bien sûr, examinons quelques implémentations concrètes du design pattern Prototype en C# pour illustrer son utilité et les situations dans lesquelles il est particulièrement adapté.

### Exemple 1: Création de Configurations Système

Imaginons que vous ayez une classe de configuration système complexe. Au lieu de recréer cette configuration à chaque fois, vous pouvez cloner un prototype.

```csharp
public class SystemConfiguration : ICloneable
{
    public string ConfigurationName { get; set; }
    public Dictionary<string, string> Settings { get; set; }

    public SystemConfiguration(string name)
    {
        ConfigurationName = name;
        Settings = new Dictionary<string, string>();
    }

    public object Clone()
    {
        // Clonage en profondeur
        var clone = (SystemConfiguration)this.MemberwiseClone();
        clone.Settings = new Dictionary<string, string>(this.Settings);
        return clone;
    }
}
```

#### Utilisation

```csharp
var baseConfig = new SystemConfiguration("BaseConfig");
baseConfig.Settings.Add("Setting1", "Value1");

// Cloner la configuration
var newConfig = (SystemConfiguration)baseConfig.Clone();
newConfig.ConfigurationName = "NewConfig";
newConfig.Settings["Setting1"] = "NewValue";

// Les deux configurations sont distinctes mais partagent des structures similaires.
```

### Exemple 2: Prototypage de Produits dans un Système E-Commerce

Considérons un scénario e-commerce où vous avez un objet `Product` que vous souhaitez dupliquer pour créer des variantes.

```csharp
public class Product : ICloneable
{
    public string Name { get; set; }
    public decimal Price { get; set; }

    public object Clone()
    {
        return this.MemberwiseClone();
    }
}
```

#### Utilisation

```csharp
var originalProduct = new Product { Name = "Original Product", Price = 100.00m };

// Cloner le produit pour créer une variante
var variantProduct = (Product)originalProduct.Clone();
variantProduct.Name = "Variant Product";
variantProduct.Price = 80.00m; // Prix différent pour la variante

// Les deux produits sont distincts mais ont été créés rapidement à partir d'un prototype.
```

### Quand utiliser le Pattern Prototype

1. **Optimisation des Ressources** : Lorsque l'initialisation d'un objet est coûteuse en termes de temps ou de ressources, et que vous avez un objet existant similaire à utiliser comme base.

2. **Évitement de la Construction Complexe** : Lorsque la création d'un objet implique des étapes de construction complexes ou une configuration importante, et que vous souhaitez éviter de répéter ce processus.

3. **Variations sur un Thème** : Dans les scénarios où vous avez besoin de multiples variations d'un objet, mais avec des modifications mineures par rapport à un objet de base.

4. **Tests et Mocks** : En testant, vous pouvez utiliser des prototypes pour créer rapidement des mock objects avec des états prédéfinis, facilitant la mise en place de tests.

### Avantages du Prototype

- **Performance** : Cloner un objet est souvent plus rapide que de le créer de zéro.
- **Flexibilité** : Permet de modifier le clone après sa création, offrant une grande flexibilité pour créer des variations.

### Inconvénients

- **Clonage en Profondeur** : La gestion du clonage en profondeur peut devenir complexe, surtout si l'objet a des références imbriquées à d'autres objets.
- **Gestion des Références** : Il faut être prudent pour gérer correctement les références lors du clonage, pour éviter des modifications inattendues sur l'objet cloné.

Ces exemples illustrent la puissance et la flexibilité du pattern Prototype dans des situations où il est avantageux de copier des objets existants plutôt que de les recréer entièrement.

## Builder

Bien sûr, examinons le pattern Builder en C# à travers quelques exemples concrets. Ce design pattern est utilisé pour construire un objet complexe étape par étape. Le Builder est particulièrement utile lorsque vous avez un objet avec plusieurs propriétés, dont certaines sont optionnelles, et vous voulez rendre le processus de construction plus clair et plus flexible.

### Exemple 1: Construction d'un Rapport

Imaginons que vous ayez besoin de construire un rapport complexe avec différentes sections. Au lieu de créer un constructeur très complexe ou de nombreuses surcharges, vous pouvez utiliser le Builder.

```csharp
// Produit
public class Report
{
    public string Header { get; set; }
    public string Footer { get; set; }
    public List<string> Content { get; } = new List<string>();

    public override string ToString()
    {
        return $"{Header}\n{string.Join("\n", Content)}\n{Footer}";
    }
}

// Builder
public class ReportBuilder
{
    private Report _report = new Report();

    public ReportBuilder AddHeader(string header)
    {
        _report.Header = header;
        return this;
    }

    public ReportBuilder AddContent(string content)
    {
        _report.Content.Add(content);
        return this;
    }

    public ReportBuilder AddFooter(string footer)
    {
        _report.Footer = footer;
        return this;
    }

    public Report Build()
    {
        Report builtReport = _report;
        _report = new Report(); // Réinitialiser pour le prochain build
        return builtReport;
    }
}
```

#### Utilisation

```csharp
var builder = new ReportBuilder();
var report = builder.AddHeader("Report Header")
                    .AddContent("Content 1")
                    .AddContent("Content 2")
                    .AddFooter("Report Footer")
                    .Build();

Console.WriteLine(report);
```

### Exemple 2: Construction d'une Configuration de Serveur

Supposons que vous ayez une classe `ServerConfiguration` avec plusieurs paramètres, certains obligatoires et d'autres optionnels.

```csharp
// Produit
public class ServerConfiguration
{
    public string IPAddress { get; set; }
    public int Port { get; set; }
    public int Timeout { get; set; }
    public bool UseSsl { get; set; }
}

// Builder
public class ServerConfigurationBuilder
{
    private ServerConfiguration _config = new ServerConfiguration();

    public ServerConfigurationBuilder WithIPAddress(string ipAddress)
    {
        _config.IPAddress = ipAddress;
        return this;
    }

    public ServerConfigurationBuilder WithPort(int port)
    {
        _config.Port = port;
        return this;
    }

    public ServerConfigurationBuilder WithTimeout(int timeout)
    {
        _config.Timeout = timeout;
        return this;
    }

    public ServerConfigurationBuilder UseSsl(bool useSsl)
    {
        _config.UseSsl = useSsl;
        return this;
    }

    public ServerConfiguration Build()
    {
        return _config;
    }
}
```

#### Utilisation

```csharp
var configBuilder = new ServerConfigurationBuilder();
var serverConfig = configBuilder.WithIPAddress("192.168.1.1")
                                .WithPort(8080)
                                .WithTimeout(1000)
                                .UseSsl(true)
                                .Build();

// Utiliser serverConfig...
```

### Quand utiliser le Pattern Builder

1. **Objets Complexes** : Lorsque la création d'un objet implique de nombreux paramètres, certains pouvant être optionnels.

2. **Lisibilité** : Pour améliorer la lisibilité et la maintenance du code lors de la construction d'objets.

3. **Immutabilité** : Lorsque vous souhaitez construire un objet immuable sans exposer de setters.

### Avantages du Builder

- **Lisibilité et Clarté** : Chaque étape de la construction est claire et le code est plus lisible.
- **Flexibilité** : Permet de créer différentes représentations d'un objet en utilisant le même code de construction.
- **Immutabilité** : Une fois construit, l'objet peut être rendu immuable.

### Inconvénients

- **Complexité supplémentaire** : Peut ajouter de la complexité inutile si l'objet à construire n'est pas suffisamment complexe.
- **Duplication de Code** : Peut entraîner une certaine duplication de code entre le Builder et le produit final.

Le pattern Builder est donc idéal pour des situations où vous avez besoin de créer des objets complexes de manière flexible et lisible.
