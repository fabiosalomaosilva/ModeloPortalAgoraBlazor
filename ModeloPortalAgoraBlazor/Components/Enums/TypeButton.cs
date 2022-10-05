namespace ModeloPortalAgoraBlazor.Components.Enums;

public enum TypeButton{
    button,
    submit,
    reset
}

public enum SizeButton{
    small,
    normal
}


public enum ColorButton{
    primary,
    secondary,
    outlinePrimary,
    outlineSecondary
}

public enum TypeMask{
    none,
    text,
    numeric,
    money
}

public static class AlertType
{
    public static string Alert { get; set; } = "Alert";
    public static string Confirm { get; set; } = "Confirm";
}

public static class AlertIcon
{
    public static string Success { get; set; } = "success";
    public static string Error { get; set; } = "error";
    public static string Warning { get; set; } = "warning";
    public static string info { get; set; } = "info";
    public static string Question { get; set; } = "question";
}
